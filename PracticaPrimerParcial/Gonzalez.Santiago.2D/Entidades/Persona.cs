using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        
        public string apellido;
        public int dni;
        public int edad;
        public string nombre;

        public Persona(string apellido, int dni, int edad, string nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public virtual string Mostrar()
        {
            string auxDni, auxEdad;
            StringBuilder sb = new StringBuilder();
            auxDni = Convert.ToString(this.dni);
            auxEdad = Convert.ToString(this.edad);
            sb.AppendFormat("Apellido: {0}, DNI: {1}, Edad: {2}, Edad: {3}", this.apellido, auxDni, auxEdad,this.nombre);
            return sb.ToString();
        }
        public abstract bool ValidarAptitud();
    }
}
