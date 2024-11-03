namespace EncapsulationLearn;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Class Types *****\n");
        //Car car = new("Audi", 120, out bool danger);
        //Console.WriteLine(car);
        Motorcycle mc = new Motorcycle(20);
        Console.WriteLine(mc);
        mc.PopAWheely();

        Console.ReadLine();
    }
}

