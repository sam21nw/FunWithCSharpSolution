namespace FunWithClasses
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string? driverName;

        public Motorcycle()
        { }

        public Motorcycle(int intensity = 0, string name = "default")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

        public void SetDriverName(string name)
        { driverName = name; }

        public void PopAWheely()
        {
            for (int i = 0;i < driverIntensity;i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaaaaw!");
            }
        }

        public override string ToString()
        {
            string result = $"Driver name:{driverName}, Intensity:{driverIntensity}";

            Console.WriteLine(result);
            PopAWheely();
            return "";
        }
    }
}