using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Calculations
    {
        #region Methods


        public static int Sum(int Finteger,int  Sinteger)
        {
            return Finteger + Sinteger;
        }
        public static int Minus(int Finteger, int Sinteger)
        {
            return Finteger - Sinteger;
        }
        public static int Multi(int Finteger, int Sinteger)
        {
            return Finteger * Sinteger;
        }
        public static decimal Divide(int Finteger, int Sinteger)
        {
            return Convert.ToDecimal(Finteger) / Convert.ToDecimal(Sinteger);
        }
        #endregion
    }
}
