public class Pair<TFirst, TSecond>
{
  public TFirst First { get; }
  public TSecond Second { get; }

  public Pair(TFirst first, TSecond second)
  {
    this.First = first;
    this.Second = second;
  }
}