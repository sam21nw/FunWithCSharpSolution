using System.IO;
using System.Text;

namespace FileStreamApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with FileStreams *****");
        using FileStream fileStream = File.Open("myMessage.dat", FileMode.Create);
        string message = "Hello World!";
        byte[] msgAsByteArray = Encoding.Default.GetBytes(message);

        fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
        fileStream.Position = 0;

        Console.WriteLine("Your message as an array of bytes: ");
        byte[] bytesFromFile = new byte[msgAsByteArray.Length];
        for (int i = 0; i < msgAsByteArray.Length; i++)
        {
            bytesFromFile[i] = (byte)fileStream.ReadByte();
        }
        Console.WriteLine(String.Join(", ", bytesFromFile));

        Console.Write("\nDecoded Message: ");
        Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
        Console.ReadLine();
        //File.Delete("myMessage.dat");
    }
}
