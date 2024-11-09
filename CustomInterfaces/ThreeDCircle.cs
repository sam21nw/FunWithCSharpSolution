namespace CustomInterfaces;
internal class ThreeDCircle : Shape, IDraw3D
{
    public ThreeDCircle() { }

    public ThreeDCircle(string name) : base(name) { }

    public void Draw3D()
    {
        Console.WriteLine("Drawing 3D circle");
    }
}
