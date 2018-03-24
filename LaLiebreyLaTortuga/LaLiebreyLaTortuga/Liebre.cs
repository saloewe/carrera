using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiebreyLaTortuga
{
    class Liebre:Corredor
    {
        private int posicion;
        public int Lugar { get { return posicion; } }
        public Liebre()
        {
            posicion = 0;
        }
        public void Accion(int proba)
        {
            if (proba < 2)
            {
                posicion += 0;
            }
            else if (proba < 4)
            {
                posicion += 9;
            }
            else if(proba < 5)
            {
                posicion += -12;
            }else if(proba < 8)
            {
                posicion += 1;
            }
            else
            {
                posicion += -2;
            }
        }
    }

}
