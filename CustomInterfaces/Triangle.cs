namespace CustomInterfaces;
internal class Triangle : Shape, IPointy
{
    public Triangle() { }
    public Triangle(string name) : base(name) { }
    public override void Draw()
    {
        Console.WriteLine($"Drawing the triangle: {PetName}");
    }
    public byte Points => 3;
}
