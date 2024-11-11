namespace GenericCollections;

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