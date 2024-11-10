using System.Collections;
using System.Collections.Generic;

namespace GenericCollections;

internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Person> people = new List<Person>()
        {
        new Person {FirstName= "Homer", LastName="Simpson", Age=47},
        new Person {FirstName= "Marge", LastName="Simpson", Age=45},
        new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
        new Person {FirstName= "Bart", LastName="Simpson", Age=8}
        };
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }

        Console.ReadLine();
    }
}

public class Person
{
    public int Age { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public Person() { }

    public Person(string fn, string ln, int age)
    {
        FirstName = fn;
        LastName = ln;
        Age = age;
    }
    public override string ToString()
    {
        return $"Name. {FirstName} {LastName}, Age: {Age}";
    }

}