using System;
using System.Collections.Generic;
using System.Text;

namespace Municipality
{
    internal class Residant
    {
        public string Name;
        public string address;
        public int accNum;
        public int monthlyUsage;

        public Residant(string name, string add, int accnum, int monthUs)
        {
            Name = name;
            address = add;
            accNum = accnum;
            monthlyUsage = monthUs;
        }

    }
}
