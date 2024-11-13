namespace SimpleFileIO;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Simple IO with the File type *****");
        var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}temp{Path.DirectorySeparatorChar}Test.dat";

        //var f = new FileInfo(fileName);
        using FileStream fs = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        fs.Close();
        using (StreamWriter sw = File.AppendText(fileName))
        {
            if (sw.NewLine == "")
            {
                sw.WriteLine("New Line");
            }
        }
        using (StreamReader sr = File.OpenText(fileName))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.ReadLine();
    }
}
