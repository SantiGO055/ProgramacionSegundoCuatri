using System;

namespace GuiaEjercicio1
{
    class Program
    {
        static int primerNumero;
        static int segundoNumero;
        static int tercerNumero;
        static int cuartoNumero;
        static int quintoNumero;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: \n");
            int.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Ingrese otro numero: \n");
            int.TryParse(Console.ReadLine(), out segundoNumero);
            Console.WriteLine("Ingrese un numero: \n");
            int.TryParse(Console.ReadLine(), out tercerNumero);
            Console.WriteLine("Ingrese otro numero: \n");
            int.TryParse(Console.ReadLine(), out cuartoNumero);
            Console.WriteLine("Ingrese un numero: \n");
            int.TryParse(Console.ReadLine(), out quintoNumero);

            System.Console.Clear();
            
            

            Console.ReadKey();
        }
    }
}
