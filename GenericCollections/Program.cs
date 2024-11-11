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
