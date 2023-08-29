// See https://aka.ms/new-console-template for more information

using System;


var p1 = new Point(2, 3);
// p1.X = 10; // position record are immutable by default
Console.WriteLine(p1);
var (x, y) = p1;

Console.WriteLine($"x = {x}, y = {y}");

var p2 = new Point { X = 10, Y = 11 };
Console.WriteLine(p2);

//record Point(int X, int Y)

record Point(int X, int Y)
{
    public Point() : this(0, 0)
    {

    }
}