namespace EncapsulationLearn;

internal record Motorcycle
{
    private string? _driverName;
    private int _driverIntensity;
    public Motorcycle(int intensity)
        : this("", intensity) { Console.WriteLine("In constructor taking an int"); }
    public Motorcycle(string name)
        : this(name, 0) { Console.WriteLine("In constructor taking a string"); }

    public Motorcycle(string driverName = "Rocky", int intensity = 0)
    {
        Console.WriteLine("In main constructor");
        _driverName = driverName;
        if (intensity > 10)
            intensity = 10;
        _driverIntensity = intensity;
    }

    //private void SetIntensity(int intensity)
    //{
    //    if (intensity > 10)
    //        intensity = 10;
    //    _driverIntensity = intensity;
    //}

    public void PopAWheely()
    {
        for (int i = 0;i < _driverIntensity;i++)
        {
            Console.WriteLine("Yeeeeeeeeee haaaaaaaaawwwwww");
        }
    }
    public override string ToString()
    {
        return $"Driver Name: {_driverName}, Intensity: {_driverIntensity}";
    }
}
