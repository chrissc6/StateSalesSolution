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
