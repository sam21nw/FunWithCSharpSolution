namespace consoleApp
{
    internal class ProcessData
    {
        public static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine(sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}