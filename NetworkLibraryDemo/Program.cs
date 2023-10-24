using OriginalCircuit.Electronics.TestEquipment;
using OriginalCircuit.Electronics.TestEquipment.FunctionGenerator.SiglentSDG;
using OriginalCircuit.Electronics.TestEquipment.Oscilloscope.RigolMSO5000;

namespace NetworkLibraryDemo
{
    internal static class Program
    {
        public static NetworkTestInstrument FunctionGen { get; } = new SiglentSDGInstrument();
        public static NetworkTestInstrument Oscilloscope { get; } = new RigolMSO5000Instrument();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}