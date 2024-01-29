QueryStringWithRawDelegates();

static void QueryStringWithRawDelegates()
{
    Console.WriteLine("***** Using Raw delegates *****");
    string[] currentVideoGames = ["Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"];

    Func<string, bool> searchFilter = new(Filter);
    Func<string, string> itemToProcess = new(ProcessItem);

    var subset = currentVideoGames.Where(searchFilter)
        .OrderBy(itemToProcess)
        .Select(itemToProcess);

    foreach (var game in subset)
    {
        Console.WriteLine("Item: {0}", game);
    }

    static bool Filter(string game)
    {
        return game.Contains(' ');
    }

    static string ProcessItem(string game)
    {
        return game;
    }
}



//Console.WriteLine("***** Fun with LINQ to Objects *****\n");
//LinqOverArray.QueryOverStrings();

//Console.WriteLine("***** Linq Over Collections *****");
//List<Car> myCars = [
//  new() { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
//    new() { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
//    new() { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
//    new() { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
//    new() { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
//];

//GetFastCars(myCars);

//ArrayList myCars = [
//    new Car { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
//    new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
//    new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
//    new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
//    new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
//  ];

//myCars.OfType<Car>().GetFastCars();
