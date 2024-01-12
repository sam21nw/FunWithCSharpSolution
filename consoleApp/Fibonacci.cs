using System;
using System.Collections.Generic;

namespace consoleApp
{
  public class FibonacciClass
  {
    public static List<int> Fibonacci(int num)
    {
      List<int> fibList = new List<int>() { 0, 1 };

      for (int i = 2; i <= num; i++)
      {
        fibList.Add(fibList[i - 1] + fibList[i - 2]);
      }
      return fibList;
    }
  }
}
