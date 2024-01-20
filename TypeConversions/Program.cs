Console.WriteLine("***** Fun with type conversions *****");
NarrowingAttempt();
ProcessBytes();
DeclareImplicitNumerics();

// Wrong result for implicit conversion
static void NarrowingAttempt()
{
    Console.WriteLine("----Narrowing Attempt----");
    byte myByte;
    int myInt = 2865;
    myByte = (byte)myInt;

    Console.WriteLine("Value of myByte: {0}", myByte);
}

// Using the checked keyword
static void ProcessBytes()
{
    Console.WriteLine("\n----Process Bytes----");
    byte b1 = 100;
    byte b2 = 200;

    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine($"sum = {sum}");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static int Add(int x, int y)
{
    return x + y;
}

static void DeclareImplicitNumerics()
{
    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    Console.WriteLine("\n----Implicit Numerics----");
    Console.WriteLine(myUInt.GetType().Name);
    Console.WriteLine(myInt.GetType().Name);
    Console.WriteLine(myLong.GetType().Name);
    Console.WriteLine(myDouble.GetType().Name);
    Console.WriteLine(myFloat.GetType().Name);
    Console.WriteLine(myDecimal.GetType().Name);
}