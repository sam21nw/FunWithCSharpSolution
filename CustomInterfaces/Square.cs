namespace CustomInterfaces;
internal class Square : Shape, IRegularPointy
{

    public Square() { }

    public Square(string name) : base(name)
    {

    }
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
    public int SideLength { get; set; }
    public int NumberOfSides { get; set; }

    public byte Points => 4;
}
