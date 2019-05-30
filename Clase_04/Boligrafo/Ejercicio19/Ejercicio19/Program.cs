using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();

            Console.WriteLine(sumador.Sumar(2, 2));
            Console.WriteLine(sumador.Sumar("2"+" ", "4"));
            Console.WriteLine(sumador);
            Console.ReadKey();
        }
    }
}
