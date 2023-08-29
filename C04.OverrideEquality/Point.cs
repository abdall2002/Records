using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04.OverrideEquality
{
    class Point : IEquatable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public override bool Equals(object obj)
        //{
        //    Point p = obj as Point;
        //    if(p is null) 
        //    {
        //        return false;
        //    }
        //    return p.X == X && p.Y == Y;
        //}

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
            //int hash = 13;
            //hash = hash * 7 + X.GetHashCode();
            //hash = hash * 7 + Y.GetHashCode();
            //return hash;

            return HashCode.Combine(X, Y);
        }

    }

}
