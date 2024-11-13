
using System.Text;

Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");

using (StringWriter strWriter = new())
{
    strWriter.WriteLine("OOps, I did it again.");
    Console.WriteLine(strWriter);

    StringBuilder sb = new();
    sb.Insert(0, "Hey!! ");
    Console.WriteLine($"-> {sb}");
    sb.Remove(0, "He".Length);
    Console.WriteLine("-> " + sb);

    Console.WriteLine("----------------------------------");

    using StringReader sr = new(strWriter.ToString());
    string? input;
    while ((input = sr.ReadLine()) != null)
    {
        Console.WriteLine(input);

    }
}
