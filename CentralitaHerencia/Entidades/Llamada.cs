using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public virtual string Mostrar()
        {
            string auxDuracion;
            StringBuilder sb = new StringBuilder();
            auxDuracion = Convert.ToString(this.duracion);
            sb.AppendFormat("Apellido: {0}, DNI: {1}, Edad: {2}, Edad: {3}", this.nroDestino, auxDuracion, this.nroOrigen);
            return sb.ToString();
        }

        public void OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            List<Llamada> OrdenarDuracion = new List<Llamada>
            {
                llamada1,
                llamada2
            };
            //IEnumerable<Llamada> query = OrdenarDuracion.OrderBy(0 => llamada1.duracion);
            var orderByResult = from s in OrdenarDuracion orderby s.duracion select s;
        }
    }
}
