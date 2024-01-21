using System.Collections;

// SimpleArrayListCollection();
// SimpleBoxUnboxOperation();

IntCollection intArrayList = new();
intArrayList.AddInt(5);
intArrayList.AddInt(64);

foreach (var item in intArrayList)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine(intArrayList.Count);

static void SimpleArrayListCollection()
{
    System.Console.WriteLine("***** Simple arrayList collection *****");
    ArrayList strArray = new ArrayList();
    strArray.AddRange(new string[] { "First", "Second", "Third" });
    // Show number of items in ArrayList.
    System.Console.WriteLine("This collection has {0} items.", strArray.Count);
    System.Console.WriteLine();
    // Add a new item and display current count.
    strArray.Add(2);
    System.Console.WriteLine("This collection has {0} items.", strArray.Count);
    // Display contents.
    foreach (string s in strArray)
    {
        System.Console.WriteLine("Entry: {0}", s);
    }
    System.Console.WriteLine();
}

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxedInt = myInt;
    int unboxedInt = (int)boxedInt;

    System.Console.WriteLine("***** Simple box-unbox operation *****");
    System.Console.WriteLine(boxedInt.GetType());
    System.Console.WriteLine(unboxedInt);
}