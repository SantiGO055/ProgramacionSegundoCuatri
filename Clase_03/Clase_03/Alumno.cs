using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_03
{
    class Alumno
    {
        byte notaUno;
        byte notaDos;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public static string colegio;
        static Random rnd;

        public Alumno(string apellido , string nombre , int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        static Alumno()
        {
            colegio = "UTN";
            rnd = new Random();
        }


        public void calcularFinal(byte notaUno, byte notaDos) {
            if (notaUno >= 4 && notaDos >= 4)
            {
                this.notaFinal = rnd.Next(1, 10); //para no usar el random instanciado cuando se ejecute por cada alumno
                                                //va a devolver el mismo random por que se ejecuta en milesimas de segundos
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;

        }
        public string Mostrar()
        {

            return this.legajo.ToString() + "-" + this.apellido + " " +
                this.nombre + "\t" + colegio + " Nota 1: "+this.notaUno + " Nota 2: " + notaDos + " " +
                (this.notaFinal == -1 ? "DESAPROBADO": this.notaFinal.ToString);
        }

    }
}
