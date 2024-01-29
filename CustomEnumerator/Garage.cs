using System.Collections;

using CustomEnumerator;

public record Garage : IEnumerator
{
    private readonly Car[] carArray = new Car[5];

    public Garage()
    {
        carArray[0] = new Car("Rusty", 52);
        carArray[1] = new Car("Clunker", 70);
        carArray[2] = new Car("Zippy", 45);
        carArray[3] = new Car("Fred", 88);
        carArray[4] = new Car("Lisa", 33);
    }

    public object Current => throw new NotImplementedException();

    public IEnumerator GetEnumerator()
    {
        return carArray.GetEnumerator();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}