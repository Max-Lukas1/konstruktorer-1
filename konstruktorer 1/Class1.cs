using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bilinformation
{
    internal class bilinformation
    {
        public string modell;
        public int ålder;
        public string tillverknings_datum;
        public string tillverkare;
        public int priss;

        public bilinformation(string m, int å, string td, string t, int p)
        {
            modell = m;
            ålder = å;
            tillverknings_datum = td;
            tillverkare = t;
            priss = p; 
        }

    }
}
