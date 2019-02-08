using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDic
{
    public class StateDicL
    {
        private Dictionary<string, int> ststr = new Dictionary<string, int>();

        public void Add(string key, int data)
        {
            ststr.Add(key, data);
        }

        public int GetTotalSales(string key, string key2, string key3, string key4)
        {
            int total = 0;
            total = Get(key) + Get(key2) + Get(key3) + Get(key4);
            return total;

        }

        public int GetTotalSales(string key, string key2, string key3)
        {
            int total = 0;
            total = Get(key) + Get(key2) + Get(key3);
            return total;
            
        }

        public int Get(string key)
        {
            return ststr[key];
        }

        public List<int> Vaules()
        {
            return ststr.Values.ToList();
        }

    }
}
//add a method that takes in multiple states and returns the total of sales