namespace ObjectInitializers;
internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointColorEnum ColorEnum { get; set; }

    public Point(int xVal, int yVal)
    {
        X = xVal;
        Y = yVal;
        ColorEnum = PointColorEnum.Gold;
    }
    public Point(PointColorEnum pointColorEnum)
    {
        ColorEnum = pointColorEnum;
    }
    public Point() : this(PointColorEnum.BloodRed) { }
    public void DisplayStats()
    {
        Console.WriteLine("[{0}, {1}]", X, Y);
        Console.WriteLine("Point is {0}", ColorEnum);
    }
}

enum PointColorEnum
{
    LightBlue,
    BloodRed,
    Gold
}
