// See https://aka.ms/new-console-template for more information


using System;
using C04.OverrideEquality;

var p1 = new Point(2, 3);
var p2 = new Point(2, 3);

Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");     // -> print True;

var points = new Dictionary<Point, string>();

Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");
points.Add(p1, "2D Point X: 2, Y: 3");
points.Add(p2, "2D Point X: 2, Y: 3");










