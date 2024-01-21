namespace FunWithClasses
{
    internal class BankAccount
    {
        private static int s_accountNumberSeed = 1234567890;
        public string? Number { get; set; }
        public string? Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public BankAccount()
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;
        }

        public BankAccount(string? name = "dude", decimal initialBalance = 0)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial balance");
        }

        private List<Transaction> _allTransactions = [];

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

        public override string ToString()
        {
            return $"Account created => owner:{Owner} number:{Number}, balance:{Balance}";
        }
    }
}