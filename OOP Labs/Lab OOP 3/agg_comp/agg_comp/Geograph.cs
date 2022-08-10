using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agg_comp
{
     class Geograph
     {
         #region Data Fields && Props

         public int Dim1 { get; set; }
         public int Dim2 { get; set; }

        #endregion

        #region Ctor

        public Geograph()
        {
            Dim1 = Dim2 = 0;
        }
        public Geograph(int _dim1,int _dim2)
        {
            Dim1= _dim1;    
            Dim2= _dim2;
        }

        #endregion

        #region Print

        public int CArea()
        {
            return Dim1 * Dim2;
        }

        #endregion
    }
}
