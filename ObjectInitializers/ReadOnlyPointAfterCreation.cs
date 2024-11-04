namespace ObjectInitializers;
internal class ReadOnlyPointAfterCreation
{
    public int X { get; init; }
    public int Y { get; init; }
    public ReadOnlyPointAfterCreation(int xVal, int yVal)
    {
        X = xVal;
        Y = yVal;
    }
    public ReadOnlyPointAfterCreation() { }
    public void DisplayStats()
    {
        Console.WriteLine("InitOnlySetter: [{0}, {1}]", X, Y);
    }
}
