namespace FunWithCustomExceptions
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

        public Car(string name = "Porsche", int speed = 30)
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
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater than Zero...");
            }
            {
            }
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
                    throw new CarIsDeadException($"{CarName} has overheated!", "You have a lead foot", DateTime.Now)
                    {
                        HelpLink = "http://www.google.com"
                    };
                }
                Console.WriteLine($"=> Current Speed = {CurrentSpeed}");
            }
        }
    }
}