// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyDelegate d = new(Display);
BinaryOp<int> bAdd = new(Add);
BinaryOp<int> bSub = new(Sub);

BinaryOp<int> bOp = bAdd;
bOp += bSub;

d.Invoke("oops");
//Console.WriteLine(bOp.Invoke(13, 17));
bOp.Invoke(24, 67);

static void Display(string message)
{
    Console.WriteLine(message);
}
static void Add(int x, int y)
{
    Console.WriteLine(x + y);
}
static void Sub(int x, int y)
{
    Console.WriteLine(x - y);
}

public delegate void BinaryOp<T>(T x, T y);

public delegate void MyDelegate(string message);