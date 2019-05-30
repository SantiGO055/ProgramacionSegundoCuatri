using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        private bool numeroCargado;
        private int numeroTelefono;
        

        public EmisorDeWhatsapp(string mensaje,EProducto producto) :base(mensaje,producto)
        {
            this.producto = producto;
            this.mensaje = mensaje;
        }
        public int NumeroTelefono
        {
            get
            {
                return this.numeroTelefono;
            }
            set
            {
                if (numeroTelefono>=1500000000 && numeroTelefono<=1599999999)
                {
                    this.numeroTelefono = value;
                    this.numeroCargado = true;
                }
                else
                {
                    this.numeroCargado = false;
                }
                
            }
        }

        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            StringBuilder sb = new StringBuilder();
            string retorno;
            if (emisor.numeroCargado)
            {
                retorno = sb.Append(".No cargado").ToString();
            }
            else
            {
                retorno = sb.AppendFormat("Producto: {0}", emisor.numeroTelefono).ToString();
            }
            return retorno;
        }

        public override string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            string retorno;
            if (!(this.numeroCargado))
            {
                retorno = sb.AppendFormat("Producto: {0}, Mensaje: {1}, Numero Telefono: {2}\n.No se pudo enviar el mensaje",
                this.producto, this.mensaje, this.numeroTelefono).ToString();
            }
            else
            {
                retorno = sb.AppendFormat("Producto: {0}, Mensaje: {1}\n.Enviando mensaje",
                this.producto, this.mensaje).ToString();
            }

            return retorno;
        }
    }
}
