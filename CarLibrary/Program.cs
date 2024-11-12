using System.Reflection;

namespace CarLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        MiniVan mv = new MiniVan();
        //Type t = Type.GetType("CarLibrary.Car", false, true);
        Type t = typeof(Car);
        ListMethods(t);
        Console.WriteLine("----------------");
        ListFields(t);

        Console.ReadLine();

    }
    static void ListMethods(Type type)
    {
        Console.WriteLine("***** Methods *****");
        MethodInfo[] methodInfos = type.GetMethods();
        foreach (MethodInfo mi in methodInfos)
        {
            Console.WriteLine(mi.Name);
            foreach (var p in mi.GetParameters())
            {
                Console.WriteLine("-> " + p.ParameterType);
            }
        }
    }
    static void ListFields(Type type)
    {
        Console.WriteLine("***** Fields *****");
        FieldInfo[] fieldInfos = type.GetFields();
        foreach (var fi in fieldInfos)
        {
            Console.WriteLine(fi.Name);
        }
    }
}
