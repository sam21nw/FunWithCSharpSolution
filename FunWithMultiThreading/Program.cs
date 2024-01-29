Console.WriteLine("***** Multi threading *****\n");

ExactExecutingThread();

static void ExactExecutingThread()
{
    Thread thread = Thread.CurrentThread;
    thread.Name = "Test";

    Console.WriteLine(thread);

    Console.WriteLine(thread.Priority);
    Console.WriteLine(thread.Name);
    Console.WriteLine(" ");
}

