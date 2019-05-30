using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        private List<Emisor> listEmisores;
        private string region;

        private ManejadorDeEmisores()
        {
            this.listEmisores = new List<Emisor>();
        }
        public ManejadorDeEmisores(string region)
        {
            this.region = region;
        }


        public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisor)
        {
            if (manejador.listEmisores.Contains(emisor))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador == emisor);
        }

        public static bool operator +(ManejadorDeEmisores m, Emisor p)
        {
            if (m != p)
            {
                m.listEmisores.Add(p);
                return true;
            }
            else
                return false;
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            
            if (manejador != null)
            {
                foreach (Emisor emi in manejador.listEmisores)
                {
                    manejador.listEmisores.Remove(emi);
                }
                return true;
            }
            else
                return false;

        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Region: {0}, {1}",
                this.region, this.listEmisores);
            return sb.ToString();
        }
        
        public string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            string retorno;
            foreach (Emisor mensj in listEmisores)
            {
                retorno = sb.AppendLine(mensj.EnviarMensaje()).ToString();
            }
            return retorno;
        }
    }
}
