using FunWithClasses;

Console.WriteLine("***** Fun with Class Types *****\n");
Car car = new("Dude", 110, out bool danger);

BankAccount account1 = new("name", 1000);
Console.WriteLine(account1.ToString());

BankAccount account2 = new(null, 3000);
Console.WriteLine(account2.ToString());