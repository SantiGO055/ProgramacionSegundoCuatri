using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        public EConector conector;
        public string marca;
        public string modelo;

        public Periferico(string marca, string modelo )
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public Periferico(string marca, string modelo, EConector conector)
        {
            this.conector = conector;
            this.marca = marca;
            this.modelo = modelo;
        }

        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Conector: {0}, Marca: {1}, Modelo: {2}",
            p.conector, p.marca, p.modelo);
            return sb.ToString();
        }

        public abstract string ExponerDatos();

        public static bool operator ==(Periferico p1, Periferico p2)
        {
            if (p1.marca==p2.marca && p1.modelo==p2.modelo)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Periferico p1, Periferico p2)
        {
            return !(p1.marca == p2.marca);
        }


    }
}
