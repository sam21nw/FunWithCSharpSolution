namespace CustomInterfaces;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** A First Look at Interfaces *****\n");
        CloneableExample();
        Console.ReadLine();
    }

    static void CloneableExample()
    {
        string myStr = "Hello";
        OperatingSystem winOS = new(PlatformID.Win32NT, new Version());

        CloneMe(myStr);
        CloneMe(winOS);
    }
    static void CloneMe(ICloneable c)
    {
        object theClone = c.Clone();
        Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
    }
}

