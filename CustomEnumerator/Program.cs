//using System.Collections;

//using CustomEnumerator;

//Garage garage = new();

//IEnumerator carEnumerator = garage.GetEnumerator();

//while (carEnumerator.MoveNext())
//{
//    Car car = (Car)carEnumerator.Current;
//    Console.WriteLine(car);
//}

using System.Collections;

string[] strArray = ["Hello", "dude", "!"];

People people = new();
//IEnumerator peopleEnumerator = people.GetEnumerator();

//while (peopleEnumerator.MoveNext())
//{
//    Console.WriteLine(peopleEnumerator.Current);
//}

foreach (var item in people) {
    Console.WriteLine(item);
}

internal record Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public Employee()
    {
    }
    public Employee(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
    }
}

internal class People : IEnumerable
{
    private readonly Employee[] employees = new Employee[2];

    public People()
    {
        employees[0] = new Employee("Moon", "Kim");
        employees[1] = new Employee("Dude", "Macho");
    }

    //public IEnumerator GetEnumerator()
    //{
    //    return employees.GetEnumerator();
    //}
    IEnumerator IEnumerable.GetEnumerator()
    {
        return employees.GetEnumerator();
    }
}