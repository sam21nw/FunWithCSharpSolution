namespace Employees;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a subclass object and access base class functionality.
        Console.WriteLine("***** The Employee Class Hierarchy *****\n");
        {
            SalesPerson fred = new()
            {
                Age = 31, Name = "Fred", SalesNumber = 50
            };
        }
    }
}

public enum EmployeePayTypeEnum
{
    Hourly,
    Salaried,
    Commission
}

