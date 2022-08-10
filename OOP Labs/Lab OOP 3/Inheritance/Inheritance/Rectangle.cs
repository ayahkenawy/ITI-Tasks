﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
      class Rectangle:Geoshape
    {
        #region Ctor

        public Rectangle()
        {
            
        }

        public Rectangle(double _dim1,double _dim2):base(_dim1, _dim2)
        {
            //Dim1 = _dim1;
            //Dim2 = _dim2;
        }

        #endregion

        #region Cal Area

        public virtual double CArea()
        {
            return Dim1 * Dim2;
        }

        #endregion
    }
}
