namespace ObjectInitializers;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Object Init Syntax *****\n");
        // Make a Point by setting each property manually.
        //Point firstPoint = new Point();
        //firstPoint.X = 10;
        //firstPoint.Y = 10;
        //firstPoint.DisplayStats();

        // Or make a Point via a custom constructor.
        //Point anotherPoint = new Point(20, 20);
        //anotherPoint.DisplayStats();
        // Or make a Point using object init syntax.
        //Point finalPoint = new Point { X = 30, Y = 30 };
        //finalPoint.DisplayStats();

        // Calling a custom constructor.
        //Point pt = new Point(10, 16) { X = 100, Y = 100 };
        //pt.DisplayStats();

        //Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 20 };
        //goldPoint.DisplayStats();

        Rectangle rectangle = new Rectangle
        {
            TopLeft = new Point { X = 10, Y = 10 },
            BottomRight = new Point { X = 200, Y = 200 },
        };


        Console.ReadLine();
    }
}
