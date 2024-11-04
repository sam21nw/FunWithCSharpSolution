namespace EmployeeApp;
class SavingsAccount
{
    private static double s_currInterestRate = 0.04;
    private double _currBalance;

    public static double InterestRate
    {
        get { return s_currInterestRate; }
        set { s_currInterestRate = value; }
    }
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
        return InterestRate;
    }
    public double GetBalance()
    {
        return _currBalance * (1 + s_currInterestRate);
    }
}
