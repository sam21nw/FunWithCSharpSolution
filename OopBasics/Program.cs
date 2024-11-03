namespace OopBasics;

internal class Program
{
    static void Main(string[] args)
    {
        Car viper = new Car();
        viper.StartCar();

        Console.ReadLine();
    }
}

class Radio
{
    public void Power(bool turnOn)
    {
        Console.WriteLine($"Radio on: {turnOn}");
    }
}

class Car
{
    private readonly Radio? myRadio;
    public Car()
    {
        myRadio = new Radio();
    }
    public void StartCar()
    {
        var radio = new Radio();
        Console.WriteLine($"Car started");
        radio.Power(true);
    }
    public void TurnOnRadio(bool OnOff)
    {
        myRadio?.Power(OnOff);
    }
}

