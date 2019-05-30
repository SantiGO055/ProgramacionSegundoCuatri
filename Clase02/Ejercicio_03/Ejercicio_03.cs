using System;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static int numUsuario;
        static int i,j,cont=0;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out numUsuario);
            for (i=2; i<numUsuario; i++)
            {
                for (j = 1; j < i; j++) { 
                    if (i % j == 0)
                    {
                    cont++;
                    }
                }
                if (cont < 2)
                    {
                        Console.WriteLine(i);
                    }
                
                cont = 0;
            }
            Console.ReadKey();
        }
    }
}
