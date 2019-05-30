using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }
        protected Franja franja;

        public float CostoLlamada
        {
            get
            {

            }
        }
        public override string Mostrar()
        {
            return base.Mostrar();
        }
    }
}
