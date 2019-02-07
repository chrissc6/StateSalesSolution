using StateDic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSales
{
    class Program
    {
        static void Main(string[] args)
        {
            var strDicton = new StateDicL();
            strDicton.Add("OH", 90416);
            strDicton.Add("KY", 77408);
            strDicton.Add("IN", 16588);
            strDicton.Add("PA", 55043);
            strDicton.Add("MI", 60099);
            strDicton.Add("NY", 19830);
            strDicton.Add("IL", 81154);
            strDicton.Add("WI", 11679);
            strDicton.Add("MN", 94207);
            strDicton.Add("MS", 93521);

            var total = 0;

            total += strDicton.Get("IN");
            total += strDicton.Get("NY");
            total += strDicton.Get("MN");
            Console.WriteLine($"Total Sales of IN, NY, MN: {total}");

            total = 0;

            total += strDicton.Get("KY");
            total += strDicton.Get("PA");
            total += strDicton.Get("MI");
            total += strDicton.Get("IL");
            Console.WriteLine($"Total Sales of KY, PA, MI, IL: {total}");

        }
    }
}
