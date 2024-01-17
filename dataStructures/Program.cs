// var factory = new PointFactory(10);
// foreach (var point in factory.CreatePoints())
// {
//   System.Console.WriteLine($"{point.X}, {point.Y}");
// }

internal class Program
{
    private static void Main(string[] args)
    {
        var pair = new Pair<int, string>(1, "two");
        int i = pair.First;
        string s = pair.Second;

        Console.WriteLine($"i = {i}, str = {s}");
    }
}