using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeEmails : Emisor
    {
        private string email;
        private bool enviado;
        
        public EmisorDeEmails(string mensaje, EProducto producto, string email):base(mensaje,producto)
        {
            this.email = email;
            this.enviado = false;
            this.producto = producto;
            this.mensaje = mensaje;
        }

        public override string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            string retorno;
            if (!(this.enviado))
            {
                retorno = sb.AppendFormat("Producto: {0}, Mensaje: {1}, Email: {2}, Enviado: {3}\n.Se envia mensaje",
                this.email, this.enviado, this.producto, this.mensaje).ToString();
                this.enviado = true;
            }
            else
            {
                retorno = sb.AppendFormat("Producto: {0}, Mensaje: {1}, Email: {2}, Enviado: {3}\n.Error, el mensaje ya fue enviado",
                this.email, this.enviado, this.producto, this.mensaje).ToString();
            }
            
            return retorno;
        }

        public static explicit operator string(EmisorDeEmails emisor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Producto: {0}, Mensaje: {1}, Email: {2}, Enviado: {3}",
            emisor.email, emisor.enviado, emisor.producto, emisor.mensaje);
            return sb.ToString();
        }
    }
}
