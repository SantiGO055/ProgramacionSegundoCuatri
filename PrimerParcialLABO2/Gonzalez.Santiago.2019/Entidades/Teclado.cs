using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY,
        };

        private readonly EDistribucion distribucion;
        
        public Teclado(string marca, string modelo, EConector conector) : base (marca,modelo,conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
            this.distribucion = EDistribucion.Dvorak;
        }
        public Teclado(string marca, string modelo, EConector conector,EDistribucion region) : base(marca, modelo, conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
            this.distribucion = region;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Conector: {0}, Marca: {1}, Modelo: {2}, Modelo: {3}",
            this.conector, this.marca, this.modelo, this.distribucion);
            return sb.ToString();
        }
    }
}
