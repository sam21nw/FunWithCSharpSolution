namespace GenericPoint;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Generic point *****");
        Point<decimal> point1 = new(1.23m, 23.124m);
        Point<float> point2 = new(2.4f, 5.1f);

        Point<string> p3 = default;

        Console.WriteLine(point1);
        Console.WriteLine(point2);
        Console.WriteLine(p3);

        Console.WriteLine("-------------------");
        PatternMatching(point1);
        PatternMatching(point2);
        PatternMatching(p3);
        Console.ReadLine();
    }
    static void PatternMatching<T>(Point<T> p)
    {
        switch (p)
        {
            case Point<string> pString:
                Console.WriteLine("Point is based on strings");
                return;
            case Point<int> pInt:
                Console.WriteLine("Point is based on ints");
                return;
            case Point<double> pDouble:
                Console.WriteLine("Point is based on doubles");
                return;
            case Point<float> pFloat:
                Console.WriteLine("Point is based on floats");
                return;
            case Point<decimal> pDecimal:
                Console.WriteLine("Point is based on decimals");
                return;
            default:
                Console.WriteLine("OOps, point is based on unidentified type");
                return;
        }
    }

    public struct Point<T> where T : IEnumerable<int>
    {
        private T _xPos;
        private T _yPos;
        public Point(T xVal, T yVal)
        {
            _xPos = xVal;
            _yPos = yVal;
        }
        public T X
        {
            get { return _xPos; }
            set { _xPos = value; }
        }
        public T Y
        {
            get { return _yPos; }
            set { _yPos = value; }
        }

        // Reset fields to the default value of the type parameter.
        // The "default" keyword is overloaded in C#.
        // When used with generics, it represents the default
        // value of a type parameter.
        public void ResetPoint()
        {
            _xPos = default;
            _yPos = default;
        }

        public override string ToString()
        {
            return $"[{_xPos}, {_yPos}]";
        }
    }
}
public class BasicMath<T> where T : class
{
    public T Add(T arg1, T arg2)
    { return arg1 + arg2; }
    public T Subtract(T arg1, T arg2)
    { return arg1 - arg2; }
    public T Multiply(T arg1, T arg2)
    { return arg1 * arg2; }
    public T Divide(T arg1, T arg2)
    { return arg1 / arg2; }
}