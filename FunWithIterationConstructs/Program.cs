WhileLoopExample();

static void WhileLoopExample()
{
    string? userIsDone = string.Empty;

    while (userIsDone?.ToLower() != "yes")
    {
        Console.WriteLine("In While Loop");
        Console.Write("Are you done? [yes|no]: ");
        userIsDone = Console.ReadLine();
    }
}