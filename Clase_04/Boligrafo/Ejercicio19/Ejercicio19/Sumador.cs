using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio19
{
    class Sumador
    {
        static int cantidadSumas;
        long suma;

        public Sumador(int cantidadSumas)
        {
            Sumador.cantidadSumas = cantidadSumas;
        }
        public Sumador():this(0)
        {

        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return this.suma =a+b;
        }
        public string Sumar(string a, string b)
        {
            return a + b;
        }
    }
}
