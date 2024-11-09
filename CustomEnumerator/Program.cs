namespace CustomEnumerator;

internal static class Program
{
    private static void Main()
    {
        var carLot = new Garage();
        foreach (Car car in carLot)
        {
            Console.WriteLine($"{car.Name}, {car.Speed}");
        }
        Console.ReadLine();
    }
}