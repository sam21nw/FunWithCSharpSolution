record Garage
{
    public int NumberOfCars { get; set; }
    public Car? MyAuto { get; set; } = new Car();

    // public override string ToString()
    // {
    //     return $"Number of cars:{NumberOfCars}, My auto:{MyAuto}";
    // }
}