namespace FunWithExceptions
{
    internal class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string CarName { get; set; } = string.Empty;
        private bool _carIsDead;
        private readonly Radio _theMusicBox = new Radio();

        public Car()
        {
        }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            CarName = name;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine($"{CarName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{CarName} has overheated!");
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    throw new Exception($"{CarName} has overheated!")
                    {
                        HelpLink = "http://www.google.com",
                        Data =
                        {
                            {"TimeStamp", $"The car exploded at {DateTime.Now}"},
                            {"Cause", "You have a lead foot."}
                        }
                    };
                }
                Console.WriteLine($"=> Current Speed = {CurrentSpeed}");
            }
        }
    }
}