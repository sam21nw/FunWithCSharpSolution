// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Fun with StreamWriter / Reader App *****");
using (StreamWriter writer = File.CreateText("reminders.txt"))
{

    writer.WriteLine("Don't forget Mother's Day this year...");
    writer.WriteLine("Don't forget Father's Day this year...");
    writer.WriteLine("Don't forget these numbers:");
    for (int i = 0; i < 10; i++)
    {
        writer.Write(i + " ");
    }
    writer.Write(writer.NewLine);
}
Console.WriteLine("Created file and wrote some thoughts...");

Console.WriteLine("---------------------------------------");
Console.WriteLine("Here are your thoughts:\n");
using (StreamReader sr = File.OpenText("reminders.txt"))
{
    string? input;
    while ((input = sr.ReadLine()) != null)
    {
        Console.WriteLine(input);

    }
}

Console.ReadLine();