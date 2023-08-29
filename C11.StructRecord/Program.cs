// See https://aka.ms/new-console-template for more information

using System;

var p1 = new Point(2, 3);
// p1.X = 10; // position readonly struct record are immutable
Console.WriteLine(p1);

//public record struct Point(int X, int Y);
public readonly record struct Point(int X, int Y);

public record struct PointV2
{
    public int X;
    public int Y;

}