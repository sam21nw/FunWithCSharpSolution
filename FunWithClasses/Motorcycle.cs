namespace FunWithClasses
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name)
        { this.name = name; }

        public void PopAWheely()
        {
            for (int i = 0;i < driverIntensity;i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaaaaw!");
            }
        }

        public Motorcycle()
        { }

        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}