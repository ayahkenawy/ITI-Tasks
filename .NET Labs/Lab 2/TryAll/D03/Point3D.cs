using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
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
    }
}
