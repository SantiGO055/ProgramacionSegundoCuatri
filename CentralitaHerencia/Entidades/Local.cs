using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : base(duracion,nroDestino,nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
            this.costo = costo;
        }


        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public override string Mostrar()
        {
            string auxDuracion,auxCostoLlamada;
            StringBuilder sb = new StringBuilder();
            auxDuracion = Convert.ToString(this.duracion);
            auxCostoLlamada = Convert.ToString(this.costo);
            sb.AppendFormat("Numero destino: {0}, Duracion: {1}, Numero Origen: {2}, Edad: {3} , Costo de llamada: {4}", this.nroDestino, auxDuracion, this.nroOrigen, auxCostoLlamada);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float auxValorLlamada;
            auxValorLlamada = this.duracion * this.costo;
            return auxValorLlamada;
        }
    }
}
