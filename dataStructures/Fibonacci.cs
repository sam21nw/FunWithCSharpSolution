namespace consoleApp
{
    public class FibonacciClass
    {
        public static List<int> Fibonacci(int num)
        {
            List<int> fibList = new List<int>() { 0, 1 };

            for (int i = 2;i <= num;i++)
            {
                fibList.Add(fibList[i - 1] + fibList[i - 2]);
            }
            return fibList;
        }

        //static int Fibonacci(int n)
        //{
        //    if (n < 2)
        //    {
        //        return n;
        //    }

        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
    }
}