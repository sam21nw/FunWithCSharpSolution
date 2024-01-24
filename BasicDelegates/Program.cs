Console.WriteLine("***** Simple Delegate Example *****");

BinaryOp b = new BinaryOp(SimpleMath.Add);

Console.WriteLine(b(13, 132));

Console.WriteLine("---------------");
DisplayDelegateInfo(b);

static void DisplayDelegateInfo(Delegate delObj)
{
    foreach (Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine($"Method Name:{d.Method}, Type Name:{d.Target}");
    }
}

public class SimpleMath
{
    public static int Add(int x, int y) => x + y;

    public static int Subtract(int x, int y) => x - y;
}

public delegate int BinaryOp(int x, int y);