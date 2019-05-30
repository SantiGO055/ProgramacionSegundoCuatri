using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Operador que devuelve un string con todos los datos de un Equipo
        /// </summary>
        /// <param name="A">Equipo para mostrar los datos</param>
        public static explicit operator string(Equipo A)
        {
            StringBuilder cadenaEquipo = new StringBuilder();
            //validar si director tecnico fue o no asignado
            if (A.directorTecnico != null)
            {
                cadenaEquipo.AppendFormat("Nombre: {0}, Lista jugadores: {1}, Director Tecnico: {2}",
                A.nombre, A.jugadores, A.directorTecnico);
                return cadenaEquipo.ToString();
            }
            else 
                return "Sin dt asignado";
        }

    
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(this.directorTecnico.ValidarAptitud()==true)
                    this.directorTecnico = value;
            }
        }
        /// <summary>
        /// Operador que verifica si existe un jugador en el equipo
        /// </summary>
        /// <param name="e">Equipo para buscar el jugador</param>
        /// <param name="j">Jugador a buscar en el equipo</param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.jugadores.Contains(j);
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e==j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count <= cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
                return e;
            }
            else
                return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;
                foreach (Jugador jugador in e.jugadores)
                {
                    switch (jugador.Posicion)
                    {
                        case Posicion.Arquero:
                            arquero++;
                            break;
                        case Posicion.Defensor:
                            defensor++;
                            break;
                        case Posicion.Central:
                            central++;
                            break;
                        case Posicion.Delantero:
                            delantero++;
                            break;
                    }
                }
            if (arquero == 1 && defensor > 1 && central > 1 && delantero > 1 &&
                e.jugadores.Count == Equipo.cantidadMaximaJugadores && e.directorTecnico != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
