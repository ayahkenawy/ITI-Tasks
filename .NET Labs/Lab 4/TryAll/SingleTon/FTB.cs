using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
  
    internal class FTB
    {
       public string Manufacture { get; set; }
       public string MACAddress { get; set; }
       public Eth Ethernet { get; set; }
       //private static readonly FTB singleTon;
        //private static FTB SingleTon;

        //v01

        //public static FTB GetSingleTon(string _mac,string _manu,Eth _eth)
        //{
        //    if (SingleTon is null)
        //    {
        //      SingleTon = new FTB( _mac,  _manu,  _eth);  
        //    }

        //    return SingleTon;
        //}       
        //private FTB(string _mac, string _manu, Eth _eth)
        //{
        //    MACAddress= _mac;
        //    Manufacture= _manu;
        //    Ethernet= _eth;
        //}

        //vo2

        //static FTB()
        //{
        //    SingleTon = new FTB();
        //}

        //v03

        //private static FTB SingleTon
        //{
        //    get
        //    {
        //        if (singleTon is null)
        //        {
        //            singleTon = new FTB();
        //        }

        //        return singleTon;
        //    }
        //}

        //v04
        public static FTB SingleTon { get; } = new FTB();

    }
}
