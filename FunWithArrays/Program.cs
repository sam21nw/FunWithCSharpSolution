Console.WriteLine("***** Fun with Arrays *****");
//SimpleArrays();
RectMultidimensionalArray();

static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");
    int[] myInts = [4, 3, 59, 23, 21, 66];
    string[] booksOnDotNet = new string[100];

    foreach (var item in myInts)
    {
        Console.WriteLine(item);
    }

    //Console.WriteLine(myInts.GetType().Name);
    Console.WriteLine(booksOnDotNet.Length);
}

static void RectMultidimensionalArray()
{
    Console.WriteLine();
    int[,] myMatrix;
    myMatrix = new int[3, 3];
    for (int i = 0;i < 3;i++)
    {
        for (int j = 0;j < 3;j++)
        {
            myMatrix[i, j] = i + j;
        }
    }

    for (int i = 0;i < 3;i++)
    {
        for (int j = 0;j < 3;j++)
        {
            Console.Write(myMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}