namespace CustomGenericMethods;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Custom generic functions *****");
        int a = 3, b = 5;
        SwapFunctions.Swap(ref a, ref b);
        Console.WriteLine(String.Format($"{a}, {b}"));

        Console.WriteLine("--------------------------");
        Person p1 = new("Dude", "Rock", 32);
        Person p2 = new("Manuel", "Blonde", 36);
        SwapFunctions.Swap<Person>(ref p1, ref p2);
        Console.WriteLine(String.Format($"{p1}, {p2}"));

        Console.ReadLine();
    }
}

public static class SwapFunctions
{
    public static void Swap(ref int a, ref int b)
    {
        //(b, a) = (a, b);
        int temp = a;
        a = b;
        b = temp;
    }
    public static void Swap<T>(ref T a, ref T b) where T : class
    {
        Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
        (b, a) = (a, b);
    }
}
