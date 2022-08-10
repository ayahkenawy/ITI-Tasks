using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Geoshape
    {
        #region Fields && Props

        public double Dim1 { get; set; }
        public double Dim2 { get; set; }

        #endregion

        #region Ctor

        public Geoshape()
        {
            Dim1 = Dim2 = 0;
        }
        public Geoshape(double _dim1, double _dim2)
        {
            Dim1= _dim1;
            Dim2= _dim2;
        }

        #endregion

        #region Method Area

        public double CArea()
        {
            return -1;
        }

        #endregion
    }
}
