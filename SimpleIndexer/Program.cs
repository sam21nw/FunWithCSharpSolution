using System.Collections;
using System.Data;
namespace SimpleIndexer;

internal class Program
{
    static void Main(string[] args)
    {
        // Indexers allow you to access items in an array-like fashion.
        Console.WriteLine("***** Fun with Indexers *****\n");
    }
}

public class PersonCollection : IEnumerable
{
    private ArrayList arPeople = new ArrayList();

    public Person this[int index]
    {
        get => (Person)arPeople[index];
        set => arPeople.Insert(index, value);
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}