namespace FunWithClasses
{
    internal class SavingsAccount
    {
        public static double currentInterestRate;
        public double currBalance;
        public double totalBalance;

        // A static constructor
        static SavingsAccount()
        {
            currentInterestRate = 0.08;
            Console.WriteLine("Static constructor will run only once...");
        }

        public SavingsAccount(double balance)
        {
            currBalance = balance;
            totalBalance = currBalance * (1 + currentInterestRate);
        }

        public static void SetInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        }

        public static double GetInterestRate() => currentInterestRate;

        public override string ToString()
        {
            return $"Interest rate:{currentInterestRate}, Current Balance: {currBalance}, Total Balance:{totalBalance}";
        }
    }
}

//internal class SavingsAccount(double balance)
//{
//    public static double currentInterestRate = 0.04;
//    public double currBalance = balance;

//    public override string ToString()
//    {
//        return $"Interest rate:{currentInterestRate}, Balance:{currBalance}";
//    }
//}