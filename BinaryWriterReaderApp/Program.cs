Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");

FileInfo f = new("BinFile.dat");
using (BinaryWriter bw = new(f.OpenWrite()))
{
    Console.WriteLine($"Base stream is: {bw.BaseStream}");

    double aDouble = 1234.67;
    int anInt = 342324;
    string aString = "Hello World";
    bw.Write(aDouble);
    bw.Write(anInt);
    bw.Write(aString);
}
Console.WriteLine("Writing Done!");

using (BinaryReader br = new(f.OpenRead()))
{
    Console.WriteLine(br.ReadDouble());
    Console.WriteLine(br.ReadString());
    Console.WriteLine(br.ReadInt32());
}
Console.ReadLine();
