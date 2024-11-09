using System.Collections;

namespace CustomEnumerator;

public class Garage : IEnumerable
{
    private readonly Car[] _carsArray = new Car[4];

    public Garage()
    {
        _carsArray[0] = new Car("Rusty", 30);
        _carsArray[1] = new Car("Clunker", 55);
        _carsArray[2] = new Car("Zippy", 30);
        _carsArray[3] = new Car("Fred", 30);
    }

    public IEnumerator GetEnumerator()
    {
        return _carsArray.GetEnumerator();
    }
}