namespace CustomInterfaces;
internal class Hexagon : Shape, IPointy, IDraw3D
{
    public Hexagon() { }
    public Hexagon(string name) : base(name) { }
    public override void Draw()
    {
        Console.WriteLine($"Drawing the hexagon: {PetName}");
    }

    public void Draw3D()
    {
        Console.WriteLine("Drawing Hexagon in 3D");
    }

    public byte Points => 6;
}
