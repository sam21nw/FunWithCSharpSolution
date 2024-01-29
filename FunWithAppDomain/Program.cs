Console.WriteLine("***** Fun with the default AppDomain *****\n");

DisplayDADStats();

static void DisplayDADStats()
{
    AppDomain defaultAD = AppDomain.CurrentDomain;
    Console.WriteLine(defaultAD.FriendlyName);
    Console.WriteLine(defaultAD.BaseDirectory);

    foreach (var assembly in defaultAD.GetAssemblies()) {

        Console.WriteLine("Name, Version: " + assembly);
    }
}
