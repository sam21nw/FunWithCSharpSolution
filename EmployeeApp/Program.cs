namespace EmployeeApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("***** Fun with Encapsulation *****");

        Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.
Hourly, new DateTime(2023, 12, 2));
        emp.DisplayStats();
        emp.GiveBonus(100);
        emp.DisplayStats();

        Console.ReadLine();
    }
}

public enum EmployeePayTypeEnum
{
    Hourly,
    Salaried,
    Commission
}

