using FunWithClasses;

Console.WriteLine("***** Fun with Class Types *****\n");
//Motorcycle motorcycle = new(2, "Dude");
//Console.WriteLine(motorcycle);

SavingsAccount account = new(1000);
Console.WriteLine(account);

SavingsAccount.SetInterestRate(0.05);
SavingsAccount account1 = new(500);
Console.WriteLine(account1);