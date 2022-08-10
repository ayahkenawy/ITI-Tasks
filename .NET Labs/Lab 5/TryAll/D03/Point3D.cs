using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    public class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {

        }

        public Point3D(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        public override string ToString()
        {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }

        public object Clone()
        {
            return new Point3D {X = this.X, Y = this.Y, Z = this.Z};
        }

        public int CompareTo(object obj)
        {
            Point3D right = obj as Point3D;
            if (this.X == right.X)
            {
                if (this.Y == right.Y)
                {
                    return this.Z.CompareTo(right.Z);
                }
                else
                {
                    return this.Y.CompareTo(right.Y);
                }
                 
            }
            else
            {
                return this.X.CompareTo(right.X);
            }
        }
        public override bool Equals(object obj)
        {
            Point3D right = obj as Point3D;
            if (right is null) return false;

            if (this.GetType() != right.GetType()) return false;

            if (object.ReferenceEquals(this, right) == true) return true;

            return this.X == right.X && this.Y == right.Y && this.Z == right.Z;
            
        }
    }
}
