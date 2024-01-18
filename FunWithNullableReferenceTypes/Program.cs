# nullable enable

TestClass? myNullableClass = null;

Console.WriteLine(myNullableClass.Name);

public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}