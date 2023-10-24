using System.Net.Sockets;
using System.Text;

string multimeterIp = "10.0.0.55"; // IP address of the multimeter
int multimeterPort = 5025; // Port number of the multimeter

string supplyIp = "10.0.0.132"; // IP address of the power supply
int supplyPort = 5555; // Port number of the power supply

string voltageCommand = "MEAS:VOLT:DC?\n"; // Command to measure DC voltage

string setCommand = "APPL CH1,{0:0.0}\n";

double voltageSetPoint = 0.5;
bool increasing = true;

Console.WriteLine($"Connecting to multimeter on {multimeterIp}:{multimeterPort} and supply on {supplyIp}:{supplyPort}");

using var multimeterClient = new TcpClient(multimeterIp, multimeterPort);
using var multimeterStream = multimeterClient.GetStream();

using var supplyClient = new TcpClient(supplyIp, supplyPort);
using var supplyStream = supplyClient.GetStream();

Console.WriteLine("Connected!");

await SendCommandAsync(supplyStream, string.Format(setCommand, voltageSetPoint));

await SendCommandAsync(supplyStream, "OUTP CH1,ON\n");

while (true)
{
    // Set voltage
    await SendCommandAsync(supplyStream, string.Format(setCommand, voltageSetPoint));

    Thread.Sleep(100);
    
    // Read voltage
    await SendCommandAsync(multimeterStream, voltageCommand);

    var responseBytes = new byte[256];
    var responseLength = multimeterStream.Read(responseBytes, 0, responseBytes.Length);
    var response = Encoding.ASCII.GetString(responseBytes, 0, responseLength).Trim();

    var voltageReading = double.Parse(response, System.Globalization.NumberStyles.Float);

    Console.WriteLine($"Voltage: {ConvertToSIUnits(voltageReading)}V");

    if (increasing)
    {
        voltageSetPoint += 0.5;
        if (voltageSetPoint >= 30)
            increasing = false;
    }
    else
    {
        voltageSetPoint -= 0.5;
        if (voltageSetPoint <= 0.5)
            increasing = true;
    }

    Thread.Sleep(900);
}

static async Task SendCommandAsync(NetworkStream stream, string command)
{
    var commandBytes = Encoding.ASCII.GetBytes(command);
    await stream.WriteAsync(commandBytes, 0, commandBytes.Length);
}

static string ConvertToSIUnits(double? number)
{
    if (!number.HasValue)
        return string.Empty;

    string[] units = { "f", "p", "n", "μ", "m", "", "k", "M", "G" };
    double[] thresholds = {
                1e-15,
                1e-12,
                1e-9,
                1e-6,
                1e-3,
                1e0,
                1e3,
                1e6,
                1e9
            };

    int unitIndex = 0;

    for (int i = 0; i < thresholds.Length; i++)
    {
        if ((double)Math.Abs((decimal)number) < thresholds[i])
        {
            break;
        }
        unitIndex = i;
    }

    double? baseValue = number / thresholds[unitIndex];
    string result = $"{baseValue:G4}{units[unitIndex]}";

    return result;
}