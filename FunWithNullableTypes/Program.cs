// a nullable type can represent all the values of its underlying type, plus the value null

//LocalNullableVariables();
//DatabaseReader();

//TesterMethod(null);

static void TesterMethod(string[] args)
{
    //if (args != null)
    //{
    //    Console.WriteLine($"You sent me {args.Length} arguments.");
    //}
    Console.WriteLine(value: $"You sent me {args?.Length ?? 0} arguments.");
}

static void LocalNullableVariables()
{
    // Define some local nullable variables
    int? @int = 11;
    double? @double = 3.14;
    bool? @bool = null;
    char? @char = 'a';
    int?[] @ints = new int?[10];

    // Define nullable types using Nullable<T>
    Nullable<int> nullableInt = 12;
    Nullable<double> nullableDouble = 3.14f;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'b';
    Nullable<int>[] nullableIntArray = new Nullable<int>[5];

    Console.WriteLine(@int);
    Console.WriteLine(@double);
    Console.WriteLine(@bool);
    Console.WriteLine(@char);
    Console.WriteLine(@ints);

    Console.WriteLine("-------------------------");
    Console.WriteLine(nullableInt.HasValue);
    Console.WriteLine(nullableDouble.HasValue);
    Console.WriteLine(nullableBool.HasValue);
    Console.WriteLine(nullableChar.HasValue);

    Console.WriteLine("-------------------------");
    foreach (var item in nullableIntArray)
    {
        if (!item.HasValue)
        {
            Console.WriteLine("oops");
        }
        else
        {
            Console.WriteLine(item.ToString() + "Oh No");
        }
    }
}

static void DatabaseReader()
{
    Console.WriteLine("**** Database reader ****");
    DatabaseReader dr = new DatabaseReader();

    // Get Int from database
    int? i = dr.GetIntFromDatabase() ?? 100;

    Console.WriteLine($"Value of i is: {i.GetValueOrDefault()}");

    // Get bool from database
    bool? b = dr.GetBoolFromDatabase();
    if (b.HasValue)
    {
        Console.WriteLine($"Value of b is {b}");
    }
    else
    {
        Console.WriteLine($"Value of b is {b.GetValueOrDefault()}");
    }
}

internal class DatabaseReader
{
    // Nullable data field
    public int? numericValue = null;

    public bool? boolValue = true;

    // Note the nullable return type
    public int? GetIntFromDatabase()
    {
        return numericValue;
    }

    public bool? GetBoolFromDatabase()
    {
        return boolValue;
    }
}