using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Calculador
    {
        int acumulador;

        public Calculador()
        {
           this.acumulador = 0;
        }
        void Acumular(string binario)
        {
            this.acumulador += Conversor.BinarioEntero(binario);
        }
        public getResultado()
        {
            return Conversor.EnteroBinario(acumulador);
        }
    }
}
