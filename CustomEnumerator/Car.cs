namespace CustomEnumerator;

class Car
{
    public const int MaxSpeed = 100;
    public string Name { get; set; } = "";
    public int Speed { get; set; } = 0;
    private bool _isCarDead = false;
    private readonly Radio _theMusicBox = new Radio();
    public Car()
    {

    }
    public Car(string name, int speed)
    {
        Speed = speed;
        Name = name;
    }
    public void CrankTunes(bool state)
    {
        _theMusicBox.TurnOn(state);
    }
    public void Accelerate(int delta)
    {
        if (_isCarDead)
        {
            Console.WriteLine($"{Name} is out of order...");
        }
        else
        {
            Speed += delta;
            if (Speed > MaxSpeed)
            {
                Speed = 0;
                _isCarDead = true;
                throw new Exception($"{Name} has overheated!")
                {
                    HelpLink = "http://www.google.com",
                    Data =
                    {
                        {"TimeStamp", $"The car exploded at {DateTime.UtcNow}" },
                        {"Cause", "You have a lead foot." }
                    }
                };
            }
            else
            {
                Console.WriteLine($"=>  Current speed = {Speed}");
            }
        }
    }
}