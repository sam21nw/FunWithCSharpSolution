using System.Collections;

namespace CustomException;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("***** Simple Exception Example *****");
        Console.WriteLine("=> Creating a car and stepping on it!");
        Car car = new Car("Zippy", 50);
        car.CrankTunes(true);
        try
        {
            for (int i = 0;i < 10;i++)
            {
                car.Accelerate(10);
            }
        }
        catch (Exception e)
        {
            // Handle the thrown exception.
            Console.WriteLine("\n*** Error! ***");
            Console.WriteLine("Method: {0}", e.TargetSite?.DeclaringType);
            Console.WriteLine("Method: {0}", e.TargetSite?.MemberType);
            Console.WriteLine("Message: {0}", e.Message);
            Console.WriteLine("Source: {0}", e.Source);
            Console.WriteLine($"Help Link: {e.HelpLink}");
            foreach (DictionaryEntry de in e.Data)
            {
                Console.WriteLine($"{de.Key}: {de.Value}");
            }
        }
        Console.WriteLine("\n***** Out of exception logic *****");

        Console.ReadLine();

    }
}
