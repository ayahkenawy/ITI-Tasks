using System;

namespace SingleTon
{
    public enum Eth
    {
        Low,
        Medium,
        High
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            //9.SingleTon Write a class that will be used by an FTP client Project
            //Your class is needed to fully describe the Network Card[Network Interface Controller(NIC)]
            //for your machine[your machine have one and only one NIC card]. 
            //Prevent the other classes from declaring more than one object from NIC class.  
            //NIC card must have these data: Manufacture, MAC Address, Type[Ethernet or token ring – use Enumeration here]…
          
            //FTB obj=FTB.GetSingleTon("mac","manu", Eth.High);
            ////obj.MACAddress = "jxxjhfd555";
            ////obj.Manufacture = "g4mnb";
            //FTB obj2= FTB.GetSingleTon("mac2", "manu2", Eth.Low);
            //Console.WriteLine(obj2.MACAddress);
            FTB obj=FTB.SingleTon;
            FTB obj2=FTB.SingleTon;
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
       
    }
}
