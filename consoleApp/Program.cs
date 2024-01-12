using System.Collections.Generic;
using consoleApp;

internal class Program
{
  private static void Main(string[] args)
  {
    var fibList = FibonacciClass.Fibonacci(20);
    foreach (var item in fibList)
    {
      System.Console.WriteLine(item);
    }
  }
}
