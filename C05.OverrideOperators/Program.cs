// See https://aka.ms/new-console-template for more information

using System;
using C04.OverrideEquality;

var p1 = new Point(2, 3);
var p2 = new Point(2, 3);

Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");    // -> print True;
Console.WriteLine($"p1 == p2: {p1 == p2}");              // -> print True;



