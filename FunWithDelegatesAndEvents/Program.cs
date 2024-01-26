// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyDelegate d = new(Display);
//BinaryOp<int> bAdd = new(Add);
//BinaryOp<int> bSub = new(Sub);

//BinaryOp<int> bOp = bAdd + bSub;

d.Invoke("oops");
//Console.WriteLine(bOp.Invoke(13, 17));
//bOp.Invoke(24, 67);

Console.WriteLine("---------- Func -----------");
//Func<int, int, int> sum = Add;
//Console.WriteLine(sum(51, 87));

Action<int, int> sum = Add;
sum(34, 89);

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

static void Dud<T>()
{
    throw new NotImplementedException();
}

public delegate T BinaryOp<T>(T x, T y);

public delegate void MyDelegate(string message);