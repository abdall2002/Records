// See https://aka.ms/new-console-template for more information


using System;
using System.Drawing;

var p1 = new Point(2, 3);
var p2 = new Point(2, 3);

Console.WriteLine($"p1: ({p1.X}, {p1.Y})"); // p1: (2, 3)
Console.WriteLine($"p2: ({p2.X}, {p2.Y})"); // p2: (2, 3)

Console.WriteLine($"p1.Equals(p2) = {p1.Equals(p2)}");    // -> print False;
Console.WriteLine($"Object.ReferenceEquals(p1, p2) =" +
                $"{Object.ReferenceEquals(p1, p2)}");     // -> print False

p1 = p2;

Console.WriteLine($"p1.Equals(p2) = {p1.Equals(p2)}");    // -> print True;
Console.WriteLine($"Object.ReferenceEquals(p1, p2) =" +
                $"{Object.ReferenceEquals(p1, p2)}");     // -> print True