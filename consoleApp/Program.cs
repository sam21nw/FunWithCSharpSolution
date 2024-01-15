internal class Program
{
    private static void Main(string[] args)
    {
        static int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        int fib = Fib(10);

        Console.WriteLine(fib);
    }
}