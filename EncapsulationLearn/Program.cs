namespace ClassTypesLearn;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Class Types *****\n");
        Car car = new("Audi", 100, out bool danger);
        //Console.WriteLine(car);
        //Motorcycle mc = new Motorcycle(20);
        //Console.WriteLine(mc);
        //mc.PopAWheely();
        for (int i = 0;i < 10;i++)
        {
            car.SpeedUp(10);
            Console.WriteLine(car);
        }


        Console.ReadLine();
    }
}

