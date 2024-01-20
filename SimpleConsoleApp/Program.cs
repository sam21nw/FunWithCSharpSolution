Console.WriteLine("******** My First C# App ********");

Console.WriteLine("******** Get Args ********");
string[] theArgs = Environment.GetCommandLineArgs();
foreach (var item in theArgs)
{
    Console.WriteLine(item);
}

ShowEnvironmentDetails();
FormatNumericalData();
LinqQueryOverInts();

return 0;

static void ShowEnvironmentDetails()
{
    Console.WriteLine("\n******** Environment class ********");
    Console.WriteLine(Environment.OSVersion);
    Console.WriteLine(Environment.MachineName);
    Console.WriteLine(Environment.CurrentDirectory);
    Console.WriteLine(Environment.Version);
    Console.WriteLine(Environment.OSVersion);
}

static void FormatNumericalData()
{
    Console.WriteLine("\n******** Formatting Numerical Data ********");
    Console.WriteLine($"c format: {12345:c}");
    Console.WriteLine($"d9 format: {12345:d9}");
    Console.WriteLine($"f3 format: {12345:f3}");
    Console.WriteLine($"n format: {12345:n}");
}

static void LinqQueryOverInts()
{
    Console.WriteLine("\n******** Linq subset type ********");
    int[] numbers = [10, 20, 30, 40, 3, 9, 8, 11];
    var subset = from i in numbers where i < 15 select i;

    Console.WriteLine(subset.GetType().Name);
}