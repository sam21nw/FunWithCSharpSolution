using System.IO;

namespace DirectoryApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Directory(Info) *****\n");
        DisplayImageFiles();
        Console.ReadLine();
    }
    static void ShowWindowsDirectoryInfo()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(@".");
        Console.WriteLine("***** DirectoryInfo *****");
        Console.WriteLine(directoryInfo.Exists);
        Console.WriteLine(directoryInfo.FullName);
        Console.WriteLine(directoryInfo.Name);
        Console.WriteLine(directoryInfo.LinkTarget);
        Console.WriteLine(directoryInfo.Attributes);
    }
    static void DisplayImageFiles()
    {
        DirectoryInfo directory = new DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Windows{Path.DirectorySeparatorChar}Web{Path.DirectorySeparatorChar}Wallpaper");
        FileInfo[] imageFiles = directory.GetFiles("*.jpg", SearchOption.AllDirectories);
        Console.WriteLine("Path: " + directory.ToString());
        foreach (var f in imageFiles)
        {
            Console.WriteLine("********************");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Length);
            Console.WriteLine(f.CreationTime);
            Console.WriteLine(f.Attributes);
        }
    }
}
