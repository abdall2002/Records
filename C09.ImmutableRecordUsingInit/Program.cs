﻿// See https://aka.ms/new-console-template for more information

using System;

var p1 = new Point(2, 3);
var p2 = new Point(2, 3);
var p3 = new Point
{
    X = 2,
    Y = 3
};

Console.WriteLine(p1);
Console.WriteLine(p2);

//p1.X = 10 // compile error;

Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
Console.WriteLine($"(p1 == p2): {p1 == p2}");


record Point
{
    // override object equal
    // implement IEquatable <Point>
    // override object GetHashCode
    // override ==, !=
    // override ToString();
    public Point()
    {

    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; init; }
    public int Y { get; init; }

}