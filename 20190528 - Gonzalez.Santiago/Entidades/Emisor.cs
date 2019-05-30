using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        public enum EProducto
        {
            SQLDatabase,
            MonitoringApp,
            AppHosting,
        };

        public EProducto producto;
        public string mensaje;

        protected Emisor(string mensaje,EProducto producto)
        {
            this.producto = producto;
            this.mensaje = mensaje;
        }

        public abstract string EnviarMensaje();
        
        
        public override string ToString()
        {
            return String.Format("\n.{producto} \n. {mensaje}",
            this.producto, this.mensaje);
        }
        

        public static bool operator ==(Emisor emisor, Emisor emisorDos)
        {
            if (emisor.mensaje == emisorDos.mensaje && emisor.producto == emisorDos.producto)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Emisor emisor, Emisor emisorDos)
        {
            return !(emisor.mensaje == emisorDos.mensaje);
        }
    }
}
