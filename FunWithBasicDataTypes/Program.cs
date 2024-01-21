Console.WriteLine("***** Fun with Basic Data Types *****");
ObjectFunctionality();
Console.WriteLine();
DataTypeFunctionality();
Console.WriteLine();
CharFunctionality();
Console.WriteLine();
UseDateTimes();

static void DataTypeFunctionality()
{
    Console.WriteLine("=> Datatype Functionality");
    Console.WriteLine(int.MinValue);
    Console.WriteLine(int.MaxValue);
    Console.WriteLine(double.MinValue);
    Console.WriteLine(double.MaxValue);
    Console.WriteLine(double.Epsilon);
    Console.WriteLine(double.PositiveInfinity);
    Console.WriteLine(double.NegativeInfinity);
    Console.WriteLine(double.E);
}
static void ObjectFunctionality()
{
    Console.WriteLine("=> Object Functionality");
    int myInt = default;
    bool myBoolean = default;
    Console.WriteLine("---------Bool----------");
    Console.WriteLine(myBoolean);
    Console.WriteLine($"{bool.FalseString}");
    Console.WriteLine($"{bool.TrueString}");

    Console.WriteLine();
    Console.WriteLine("---------Int----------");
    Console.WriteLine(myInt);
    Console.WriteLine(myInt.ToString());
    Console.WriteLine(myInt.GetHashCode());
    Console.WriteLine(myInt.GetType());
    Console.WriteLine(myInt.Equals(11));
    Console.WriteLine(int.TryParse("34", out int newInt));
    Console.WriteLine(newInt);
}

static void CharFunctionality()
{
    Console.WriteLine("=> Char Functionality");
    char myChar = 'p';
    Console.WriteLine(myChar);
    Console.WriteLine(char.MaxValue);
    Console.WriteLine(char.MinValue);
    Console.WriteLine(char.IsWhiteSpace(myChar));
    Console.WriteLine(char.IsPunctuation('?'));
    Console.WriteLine(myChar.GetTypeCode());
    Console.WriteLine(char.TryParse("d", out char result));
    Console.WriteLine(result);
}

static void UseDateTimes()
{
    Console.WriteLine("=> Dates and Times");
    DateTime dt = DateTime.Now;
    Console.WriteLine(dt.ToString());

    TimeSpan ts = new TimeSpan(1500);
    Console.WriteLine(ts.ToString());
    Console.WriteLine(TimeSpan.MaxValue);
    Console.WriteLine(TimeSpan.TicksPerMinute);

    DateOnly d = new DateOnly();
    DateOnly dn = DateOnly.MaxValue;
    Console.WriteLine(d);
    Console.WriteLine(dn);
}