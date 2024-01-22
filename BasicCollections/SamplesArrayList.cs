using System.Collections;

namespace BasicCollections
{
    internal class SamplesArrayList
    {
        public static void DisplayArrayList()
        {
            ArrayList arrayList = ["Hello", "World", "!", "Dude", "OOPS"];

            Console.WriteLine("***** Sample ArrayList *****");
            Console.WriteLine("Count: " + arrayList.Count);
            Console.WriteLine("Capacity: " + arrayList.Capacity);

            Console.WriteLine("\nValues:");
            PrintValues(arrayList);

            var result = arrayList.Contains("World");
            Console.WriteLine("\n" + result);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (object obj in myList)
            {
                Console.Write(obj + " ");
            }
        }
    }
}