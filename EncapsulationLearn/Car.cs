namespace ClassTypesLearn;

internal class Car
{
    private string _name;
    private int _currSpeed;
    private bool _inDanger;
    public bool InDanger
    {
        get
        {
            return checkDanger(_currSpeed);
        }
    }

    public Car(string name, int speed, out bool startDanger)
    {
        _name = name;
        _currSpeed = speed;
        if (checkDanger(speed))
        {
            Console.WriteLine("Play starting with danger");
            startDanger = true;
        } else
        {
            startDanger = false;
        }

    }
    bool checkDanger(int currSpeed)
    {
        if (currSpeed >= 100)
            return true;
        return false;
    }
    public void SpeedUp(int delta)
    {
        _currSpeed += delta;
    }
    public override string ToString()
    {
        string printDanger = "cool";
        if (InDanger)
        {
            printDanger = "Whoopsie";
        }
        return $"Car Name: {_name}, Current Speed: {_currSpeed}, {printDanger}";
    }
}
