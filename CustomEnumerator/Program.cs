using System.Collections;

using CustomEnumerator;

Garage garage = new();

IEnumerator carEnumerator = garage.GetEnumerator();

while (carEnumerator.MoveNext())
{
    Car car = (Car)carEnumerator.Current;
    Console.WriteLine(car);
}