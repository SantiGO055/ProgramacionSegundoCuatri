using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Jugador : Persona
    {
        
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public Jugador(string apellido, int dni, int edad, string nombre, float altura, float peso, Posicion posicion) : base(apellido, dni, edad, nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Años de experiencia: ").Append(this.altura).Append(this.peso).Append(posicion);
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float IMC;
            IMC =(this.peso / (float)Math.Pow(this.altura, 2));
            if (IMC >= 18.5 && IMC <= 25)
                return 
                    true;
            else
                return false;
        }
        /// <summary>
        /// Valida la aptitud del jugador para realizar la actividad
        /// </summary>
        /// <returns>Retorna true si el jugador esta apto para jugar, caso contrario retorna false</returns>
        public override bool ValidarAptitud()
        {
            if (ValidarEstadoFisico() == true && this.edad<=40)
            {
                return true;
            }
            else
                return false;
        }
    }
}
