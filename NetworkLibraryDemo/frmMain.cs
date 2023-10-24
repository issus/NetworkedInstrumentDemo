using OriginalCircuit.Electronics.TestEquipment.Oscilloscope.RigolMSO5000;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Diagnostics;
using OriginalCircuit.Electronics.TestEquipment.FunctionGenerator.SiglentSDG;
using static OriginalCircuit.Electronics.TestEquipment.FunctionGenerator.SiglentSDG.SiglentSDGInstrument;
using static OriginalCircuit.Electronics.TestEquipment.FunctionGenerator.SiglentSDG.Commands.BasicWaveCommand;
using OriginalCircuit.Electronics.TestEquipment.Oscilloscope.RigolMSO5000.Commands;

namespace NetworkLibraryDemo
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

            cboWaveType.SelectedIndex = 0;
        }

        private async void btnSdgConnect_Click(object sender, EventArgs e)
        {
            if (btnSdgConnect.Text == "Connect")
            {
                if (!Int32.TryParse(txtMsoPort.Text, out int msoPort))
                {
                    MessageBox.Show("Invalid oscilloscope port number");
                    return;
                }

                await Program.Oscilloscope.Connect(txtMsoIp.Text, msoPort);


                if (!Program.Oscilloscope.IsConnected)
                {
                    MessageBox.Show("Failed to connect to oscilloscope");
                    return;
                }

                if (!Int32.TryParse(txtSdgPort.Text, out int sdgPort))
                {
                    MessageBox.Show("Invalid signal gen port number");
                    return;
                }

                await Program.FunctionGen.Connect(txtSdgIp.Text, sdgPort);

                if (!Program.FunctionGen.IsConnected)
                {
                    MessageBox.Show("Failed to connect to signal generator");

                    Program.Oscilloscope.Disconnect();

                    return;
                }

                await ConfigureInstruments();

                btnSdgConnect.Text = "Disconnect";
            }
            else
            {
                Program.FunctionGen.Disconnect();
                Program.Oscilloscope.Disconnect();

                btnSdgConnect.Text = "Connect";
            }
        }

        private async void tmrUpdateChart_Tick(object sender, EventArgs e)
        {
            RigolMSO5000Instrument oscilloscope = (RigolMSO5000Instrument)Program.Oscilloscope;

            if (!oscilloscope.IsConnected)
                return;

            try
            {
                var points = await oscilloscope.Waveform.Data();

                if (points == null || !points.Any())
                    return;

                var xPoints = points.Select(p => p.Time).ToArray();
                var yPoints = points.Select(p => p.Voltage).ToArray();

                chrtScopeData.Series[0].Points.Clear();
                chrtScopeData.Series[0].Points.DataBindXY(xPoints, yPoints);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async Task ConfigureInstruments()
        {
            RigolMSO5000Instrument oscilloscope = (RigolMSO5000Instrument)Program.Oscilloscope;
            SiglentSDGInstrument functionGen = (SiglentSDGInstrument)Program.FunctionGen;

            if (!oscilloscope.IsConnected || !functionGen.IsConnected)
                return;

            double frequency = (double)numFrequency.Value;
            double amplitude = (double)numAmplitude.Value;
            double riseTime = (double)numRiseTime.Value;
            double fallTime = (double)numFallTime.Value;

            await oscilloscope.Channel.SetDisplay(true, ScopeChannel.CH1);
            await oscilloscope.Channel.SetCoupling(Coupling.DC, ScopeChannel.CH1);
            await oscilloscope.Timebase.SetScale(1.0 / frequency);
            await oscilloscope.Channel.SetScale(amplitude / 4, ScopeChannel.CH1);
            await oscilloscope.Channel.SetOffset(0, ScopeChannel.CH1);
            await oscilloscope.WaitToContinue();

            await oscilloscope.Trigger.SetMode(TriggerMode.EDGE);
            await oscilloscope.Trigger.Edge.SetSource(TriggerEdgeSource.CHAN1);
            await oscilloscope.Trigger.Edge.SetSlope(TriggerSlope.POS);
            await oscilloscope.Trigger.Edge.SetLevel(amplitude / 4);
            await oscilloscope.Trigger.SetSweep(TriggerSweep.NORM);
            await oscilloscope.WaitForOperationComplete();


            var waveType = Enum.Parse<WaveType>(cboWaveType.SelectedItem.ToString());
            await functionGen.BasicWave.SetWaveType(SiglentSdgChannel.C1, waveType);
            await functionGen.BasicWave.SetFrequency(SiglentSdgChannel.C1, frequency);
            await functionGen.BasicWave.SetAmplitude(SiglentSdgChannel.C1, amplitude);
            await functionGen.BasicWave.SetRiseTime(SiglentSdgChannel.C1, riseTime);
            await functionGen.BasicWave.SetFallTime(SiglentSdgChannel.C1, fallTime);

            await functionGen.SetOutput(SiglentSdgChannel.C1, true, "HZ", Polarity.Normal);

        }

        private async void fgenInput_Changed(object sender, EventArgs e)
        {
            try
            {
                await ConfigureInstruments();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}