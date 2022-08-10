using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x,int _y,int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        public override string ToString()
        {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point3D P = (Point3D)obj;
                return (P.X == this.X) && (P.Y == this.Y) && (P.Z == this.Z);
            }
        }
    }
}
