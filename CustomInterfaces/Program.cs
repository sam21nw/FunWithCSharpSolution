﻿namespace CustomInterfaces;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("***** Fun with Interfaces *****\n");
        //var sq = new Square("Boxy")
        //{ NumberOfSides = 4, SideLength = 4 };
        //sq.Draw();
        //This won't compile
        //Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {sq.Perimeter}");
        //This will compile
        //Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

        Shape[] shapes = [new Triangle("T"), new Circle("C"), new Hexagon("Hex"), new ThreeDCircle("3DC")];

        foreach (var shape in shapes)
        {
            if (shape is IDraw3D s)
            {
                s.Draw3D();
            }
        }

        Console.WriteLine("-----------------------------");
        var firstPointItem = FindFirstPointyShape(shapes);
        Console.WriteLine($"The first pointy item found [{firstPointItem?.GetType()}] has {firstPointItem?.Points} points");

        Console.ReadLine();
    }

    private static IPointy? FindFirstPointyShape(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            if (shape is IPointy ip)
            {
                return ip;
            }
        }
        return null;
    }
}
