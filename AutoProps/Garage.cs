namespace AutoProps;
internal class Garage
{
    // The hidden int backing field is set to zero!
    public int NumberOfCars { get; set; } = 1;
    // The hidden Car backing field is set to null!
    public Car? MyAuto { get; set; } = new Car();

    // Must use constructor to override default
    // values assigned to hidden backing fields
    public Garage()
    {
    }
    public Garage(Car car, int number)
    {
        MyAuto = car;
        NumberOfCars = number;
    }
}
