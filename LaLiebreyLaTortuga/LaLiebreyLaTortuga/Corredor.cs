using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiebreyLaTortuga
{
    abstract class Corredor
    {
        static public Random rd = new Random();

        public int Correr()
        {
            return rd.Next(10);
        }
    }
}
