using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    static class MathC
    {
        public static int Add(int _x,int _y)
        {
            return _x + _y;
        }
        public static int Sub(int _x, int _y)
        {
            return _x - _y;
        }
        public static decimal Divide(int _x, int _y)
        {
            if(_y !=0) return _x / _y;
            else
            {
                return -1;
            }
        }
        public static int Multiply(int _x, int _y)
        {
            return _x * _y;
        }
    }
}
