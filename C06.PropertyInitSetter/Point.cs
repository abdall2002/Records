﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06.PropertyInitSetter
{
    class Point : IEquatable<Point>
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;

            return this.Equals(p);
        }

        public bool Equals(Point point)
        {
            if (point is null)
                return false;

            return point.X == X && point.Y == Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point lhs, Point rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }
                return false;
            }
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Point lhs, Point rhs)
        {
            return !(lhs == rhs);
        }
    }

}
