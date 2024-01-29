using System.Reflection;

Type t = typeof(Car);

ListMethods(t);
Console.WriteLine("*************");
ListFields(t);
Console.WriteLine("*************");
ListProperties(t);

Console.WriteLine("***** Various statistics *****");
Console.WriteLine("Base class is: {0}", t.BaseType);

static void ListMethods(Type t)
{
    MethodInfo[] mi = t.GetMethods();
    foreach (MethodInfo method in mi) {
        Console.WriteLine("Method->{0}", method.Name);
    }
}
static void ListFields(Type t)
{
    FieldInfo[] fi = t.GetFields();
    foreach (FieldInfo field in fi) {
        Console.WriteLine("Field->{0}", field.Name);
    }
}

static void ListProperties(Type t)
{
    PropertyInfo[] pi = t.GetProperties();
    foreach (PropertyInfo property in pi) {
        Console.WriteLine("Property->{0}", property.Name);
    }
}
class Car
{
    public readonly int total = 100;
    public int MyProperty { get; set; }

    public int GetTotal()
    {
        return total;
    }
}
