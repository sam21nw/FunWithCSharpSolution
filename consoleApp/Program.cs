internal class Program
{
    private static void Main()
    {
        List<string> animalEmojis = new List<string>()
        {
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q"
        };

        var listNums = new List<string>();

        for (int i = 0;i < 12;i++)
        {
            var randomIndex = new Random().Next(animalEmojis.Count);

            if (!listNums.Contains(animalEmojis[randomIndex]))
            {
                listNums.Add(animalEmojis[randomIndex]);
            }
        }

        foreach (var item in listNums)
        {
            Console.WriteLine(item);
        }

        //string[,] myMatrix = new string[4, 4];
        //for (int i = 0;i < 4;i++)
        //{
        //    for (int j = 0;j < 4;j++)
        //    {
        //        myMatrix[i, j] = animalEmojis[i];
        //    }
        //}

        //for (int i = 0;i < 4;i++)
        //{
        //    for (int j = 0;j < 4;j++)
        //    {
        //        Console.Write(myMatrix[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        //string[][] jaggedArray =
        //[
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //    ["", ""],
        //];

        //var random = new Random();

        //int i = 0;
        //foreach (var subArray in jaggedArray)
        //{
        //    var index = random.Next(animalEmojis.Count);
        //    int j = 0;
        //    foreach (var element in subArray)
        //    {
        //        jaggedArray[i][j] = animalEmojis[index];
        //        j++;
        //        animalEmojis.RemoveAt(index);
        //    }
        //    i++;
        //}
        //foreach (var subArray in jaggedArray)
        //{
        //    int j = 0;
        //    foreach (var element in subArray)
        //    {
        //        Console.WriteLine($"Element at jaggedArray[{i}][{j}] is: {element}");
        //        j++;
        //    }
        //    i++;
        //}
    }
}