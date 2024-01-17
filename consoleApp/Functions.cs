namespace consoleApp
{
    public class Functions
    {
        public static long Factorial(int n)
        {
            if ((n < 0) || (n > 20))
            {
                return -1;
            }
            long result = 1;
            for (int i = 1;i <= n;i++)
            {
                result *= i;
            }

            return result;
        }
    }
}