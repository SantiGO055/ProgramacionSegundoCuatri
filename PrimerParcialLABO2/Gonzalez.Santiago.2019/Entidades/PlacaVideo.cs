using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo : Periferico
    {
        private readonly int ramMB;

        public PlacaVideo(string marca,string modelo,int ramMB) : base (marca,modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ramMB = ramMB;
        }
        public PlacaVideo(string marca, string modelo, int ramMB,EConector conector) : base(marca, modelo,conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ramMB = ramMB;
            this.conector = EConector.PCIExpress;
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Conector: {0}, Marca: {1}, Modelo: {2}",
            this.conector, this.marca, this.modelo);
            return sb.ToString();
        }
    }
}
