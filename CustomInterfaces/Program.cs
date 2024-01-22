using CustomInterfaces;

Console.WriteLine("***** A First Look at Interfaces *****\n");

public class Pencil : ICloneable, IPointy
{
    public string? PropName
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public byte Points => throw new NotImplementedException();

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public byte GetNumberOFPoints()
    {
        throw new NotImplementedException();
    }
}

//CloneableExample();

//static void CloneableExample()
//{
//    string myStr = "Hello";
//    OperatingSystem operatingSystem = new(PlatformID.Win32NT, new Version());

//    CloneMe(myStr);
//    CloneMe(operatingSystem);

//    static void CloneMe(ICloneable c)
//    {
//        object theClone = c.Clone();
//        Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
//    }
//}