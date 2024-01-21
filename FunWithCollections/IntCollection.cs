using System.Collections;

// Custom collection class
// This does not solve boxing unboxing issues
public class IntCollection : IEnumerable
{
    private ArrayList arInts = new();

    // Get an int (perform unboxing!)
    public int GetInt(int pos) => (int)arInts[pos];

    // Insert an int (perform boxing!)
    public void AddInt(int i)
    {
        arInts.Add(i);
    }
    public void ClearInts()
    {
        arInts.Clear();
    }
    public int Count => arInts.Count;

    IEnumerator IEnumerable.GetEnumerator() => arInts.GetEnumerator();
}