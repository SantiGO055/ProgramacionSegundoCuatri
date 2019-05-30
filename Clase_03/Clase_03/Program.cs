using System;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Gonzalez","Santiago",5);
            Alumno alumno2 = new Alumno("Perez", "Juan",1);
            Alumno alumno3 = new Alumno("Luli", "Victoria",9);
            alumno1.Estudiar(8,7);
            
            

            Alumno.colegio = "UTN";
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
             
        }
    }
}
