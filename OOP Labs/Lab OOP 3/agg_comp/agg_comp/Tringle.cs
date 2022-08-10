using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agg_comp
{
     class Tringle
    {
        #region Fields && Props

        public Geograph Geo { get; set; } = new Geograph();

        #endregion

        #region Ctor

        public Tringle()
        {
            Geo.Dim1 = 4; Geo.Dim2 = 3;
        }
        public Tringle(Geograph _geo)
        {
            Geo = _geo;
        }

        #endregion
        public string PrintDetails()
        {
            return $"Dim 1 => {Geo.Dim1} , Dim 2 => {Geo.Dim2} , Area => {.5*Geo.CArea()} ";
        }
    }
}
