using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        int añosExperiencia;

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Años de experiencia: ").Append(this.añosExperiencia);
            return sb.ToString();
        }


        public DirectorTecnico(string apellido, int dni, int edad, string nombre, int añosExperiencia) :base(apellido,dni,edad,nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.añosExperiencia = añosExperiencia;
        }
        public override bool  ValidarAptitud()
        {
            if (this.edad <= 65 && this.añosExperiencia >= 2)
            {
                return true;
            }
            else
                return false;
        }

        public int AñosExperiencia
        {
            get
            {
                return añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
    }
}
