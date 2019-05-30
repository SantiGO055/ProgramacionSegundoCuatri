using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;
        
        private Maquina()
        {
            this.cantidadMaxPerifericos = 3;
            this.perifericos = new List<Periferico>();
        }
        public Maquina(string nombre)
        {
            this.nombre = nombre;
        }
        public int CantidadMaximaPerifericos
        {
            get
            {
                return this.cantidadMaxPerifericos;
            }
            set
            {
                if (!(value < 1 || value > 4))
                {
                    this.cantidadMaxPerifericos = value;
                }
                else
                {
                    if (value <= 1)
                    {
                        this.cantidadMaxPerifericos = 1;
                    }
                    if (value >= 4)
                    {
                        this.cantidadMaxPerifericos = 4;
                    }
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string SystemInfo
        {
            get
            {
                //terminar systeminfo
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Periferico: {0}, Nombre de la maquina: {1}",
                this.perifericos, this.nombre);
                return sb.ToString();
            }
        }
        public static bool operator ==(Maquina m, Periferico p)
        {
            if (m != null)
            {
                return m.perifericos.Contains(p);
            }
            else
                return false;
        }
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }
        public static string operator +(Maquina m, Periferico p)
        {
            if (m!=null&&m.perifericos.Contains(p) && m.perifericos.Count <= m.cantidadMaxPerifericos)
            {
                m.perifericos.Add(p);
                StringBuilder sb = new StringBuilder();
                sb.Append("Periferico conectado!");
                
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("No se puede conectar el dispositivo.");
                return sb.ToString();
            }
        }
        public static string operator -(Maquina m, Periferico p)
        {
            if (m != p && m.perifericos.Count <= m.cantidadMaxPerifericos)
            {
                m.perifericos.Remove(p);
                StringBuilder sb = new StringBuilder();
                sb.Append("Periferico Desconectado!");
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("No se puede desconectar el dispositivo.");
                return sb.ToString();
            }
        }

    }
}
