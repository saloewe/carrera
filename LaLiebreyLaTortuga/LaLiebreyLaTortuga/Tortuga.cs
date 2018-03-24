using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiebreyLaTortuga
{
    class Tortuga:Corredor
    {
        private int posicion;
        public int Lugar { get {return posicion; } }
        public Tortuga()
        {
            posicion = 0;
        }

        public void Accion(int proba)
        {
            if(proba < 5)
            {
                posicion += 3;
            }else if(proba < 8)
            {
                posicion += 1;
            }
            else
            {
                posicion += -1;
            }
        }

    }
}
