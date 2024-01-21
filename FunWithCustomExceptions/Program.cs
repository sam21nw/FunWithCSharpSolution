using FunWithCustomExceptions;

Console.WriteLine("***** Fun with Custom Exceptions *****\n");
Car car = new Car("BMW", 60);
car.CrankTunes(true);

try
{
    for (int i = 0;i < 10;i++)
    {
        car.Accelerate(-10);
    }
}
catch (CarIsDeadException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ErrorTimeStamp);
    Console.WriteLine(ex.CauseOfError);
}
catch (ArgumentOutOfRangeException ae)
{
    Console.WriteLine(ae.Message);
}
catch (Exception e) { Console.WriteLine(e.Message); }