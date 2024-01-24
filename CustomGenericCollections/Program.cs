// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string a = "Hello";
string b = "World";

Swap<string>(ref a, ref b);

Console.WriteLine($"a={a}, b={b}");

static void Swap<T>(ref T a, ref T b) where T : class
{
    (b, a) = (a, b);
}