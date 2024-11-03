namespace StaticDataAndMembers;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Static Data *****\n");
        SavingsAccount s1 = new SavingsAccount(50);
        SavingsAccount s2 = new SavingsAccount(100);

        Console.WriteLine(s2.GetBalance());
        Console.WriteLine(SavingsAccount.GetInterestRate());

        SavingsAccount.SetInterestRate(0.08);
        Console.WriteLine(SavingsAccount.GetInterestRate());

        Console.ReadLine();
    }
}

class SavingsAccount
{
    private static double s_currInterestRate = 0.04;
    private double _currBalance;
    public SavingsAccount(double initialBalance)
    {
        _currBalance = initialBalance;
    }
    public static void SetInterestRate(double newRate)
    {
        s_currInterestRate = newRate;
    }
    public static double GetInterestRate()
    {
        return s_currInterestRate;
    }
    public double GetBalance()
    {
        return _currBalance * (1 - s_currInterestRate);
    }
}