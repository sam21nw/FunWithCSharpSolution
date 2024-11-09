namespace ProcessMultipleExceptions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Handling Multiple Exceptions *****\n");
        Car myCar = new Car("Rusty", 90);
        try
        {
            myCar.Accelerate(-10);

        }
        catch (CarIsDeadException e)
        {
            Console.WriteLine(e.Message);
            //throw;
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}