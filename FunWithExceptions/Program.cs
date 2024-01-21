using System.Collections;

using FunWithExceptions;

Console.WriteLine("***** Simple Exception Example *****");
Console.WriteLine("=> Creating a car and stepping on it!");

Car car = new Car("Porsche", 40);
car.CrankTunes(true);

try
{
    for (int i = 0;i < 10;i++)
    {
        car.Accelerate(10);
    }
}
catch (Exception ex)
{
    Console.WriteLine("\n**** Error ****");
    Console.WriteLine($"Member name: {ex.TargetSite}");
    Console.WriteLine($"Class defining member: {ex.TargetSite?.DeclaringType}");
    Console.WriteLine($"Method type: {ex.TargetSite?.MemberType}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Source: {ex.Source}");
    Console.WriteLine($"Stack trace: {ex.StackTrace}");
    Console.WriteLine($"Help Link: {ex.HelpLink}");
    Console.WriteLine("\n=> Custom Data");
    foreach (DictionaryEntry de in ex.Data)
    {
        Console.WriteLine($"{de.Key}: {de.Value}");
    }
}

Console.WriteLine("\n **** Out of exception logic ****");