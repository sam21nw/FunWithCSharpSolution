public class Point
{
  public int X { get; }
  public int Y { get; }

  // public Point(int x, int y) => (X, Y) = (x, y);
  public Point(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }
}

public class Point3D : Point
{
  public int Z { get; set; }
  public Point3D(int x, int y, int z) : base(x, y)
  {
    Z = z;
  }
}