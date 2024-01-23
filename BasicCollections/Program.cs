using System.Collections;

using BasicCollections;

Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");
Garage carLot = new();
var carEnumerator = carLot.GetEnumerator();
while (carEnumerator.MoveNext())
{
    Console.WriteLine(carEnumerator.Current);
}

//var carEnumerator = carLot.GetEnumerator();
//foreach (var _ in carLot)
//{
//    carEnumerator.MoveNext();
//    Console.WriteLine(carEnumerator.Current);
//}

//Car[] carArray1 = new Car[4];

//carArray1[0] = new Car("Dude", 30);
//carArray1[1] = new Car("Clunker", 55);
//carArray1[2] = new Car("Zippy", 46);
//carArray1[3] = new Car("Fred", 78);

//foreach (var item in carArray1)
//{
//    Console.WriteLine(item);
//}

Console.ReadLine();