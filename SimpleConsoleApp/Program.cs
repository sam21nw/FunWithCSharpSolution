Console.WriteLine("******** My First C# App ********");

Console.WriteLine("******** Get Args ********");
string[] theArgs = Environment.GetCommandLineArgs();
foreach (var item in theArgs)
{
    Console.WriteLine(item);
}

Console.WriteLine("******** Environment class ********");
ShowEnvironmentDetails();

Console.WriteLine("******** Formatting Numerical Data ********");
FormatNumericalData();

return 0;

static void ShowEnvironmentDetails()
{
    Console.WriteLine(Environment.OSVersion);
    Console.WriteLine(Environment.MachineName);
    Console.WriteLine(Environment.CurrentDirectory);
    Console.WriteLine(Environment.Version);
    Console.WriteLine(Environment.OSVersion);
}

static void FormatNumericalData()
{
    Console.WriteLine($"c format: {12345:c}");
    Console.WriteLine($"d9 format: {12345:d9}");
    Console.WriteLine($"f3 format: {12345:f3}");
    Console.WriteLine($"n format: {12345:n}");
}