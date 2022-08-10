using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agg_comp
{
     class Square
    {
        #region Fields && Props

        public Geograph Geo { get; set; }

        #endregion

        #region Ctor

        public Square(Geograph _geo)
        {
            Geo = _geo;
        }

        #endregion
        public string PrintDetails()
        {
            return $"Dim 1 => {Geo.Dim1} , Dim 2 => {Geo.Dim2} , Area => {Geo.CArea()} ";
        }
    }
}
