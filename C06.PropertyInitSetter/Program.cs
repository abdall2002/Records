// See https://aka.ms/new-console-template for more information


using System;
using C06.PropertyInitSetter;

var p1 = new Point(2, 3);
var p2 = new Point(2, 3);
var p3 = new Point
{
    X = 2,
    Y = 3
};

//p1.X = 10; // compile time error access readonly property



