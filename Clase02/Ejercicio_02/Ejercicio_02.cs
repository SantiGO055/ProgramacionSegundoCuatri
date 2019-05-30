using System;
using System.Collections.Generic;
using System.Text;

namespace guiaEjerciciosProgII
{
    class Ejercicio_02
    {
        static int numero;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out numero);
            if (numero > 0)
            {
                Console.WriteLine("El cuadrado del numero ingresado es: {0}\n y el cubo es: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            }
            System.Console.ReadKey();


        }
    }
}