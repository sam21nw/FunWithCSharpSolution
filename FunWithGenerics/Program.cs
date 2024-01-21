
using System;
using System.Collections.Generic;

int[] myInts = { 3, 6, 8, 11, 14 };

System.Console.WriteLine(Array.BinarySearch<int>(myInts, 10));

Stack<int> stackOfInts = new();
stackOfInts.Push(5);
stackOfInts.Push(3);
stackOfInts.Push(11);
stackOfInts.Push(2);

System.Console.WriteLine(stackOfInts.Contains(22));

static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
