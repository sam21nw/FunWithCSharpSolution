namespace Shapes;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Polymorphism *****\n");
        Hexagon hex = new Hexagon("Beth");
        Circle circle = new Circle("Dude");
        circle.Draw();

        if (hex is Shape h)
        {
            hex.Draw();
        }

        Console.ReadLine();
    }
}
