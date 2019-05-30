using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,mitad,numUsuario,maximo=10000,divisor,cont=0;
            //Console.WriteLine("Ingrese un numero");
            //int.TryParse(Console.ReadLine(), out numUsuario);
            for (i = 6; i < maximo; i++)
            {
                
                mitad = i / 2;
                
                for (j = 1; j <= mitad; j++)
                {
                    
                    if (i%j==0)
                    {
                        cont+=j;
                    }

                }
                if (cont == i)
                {
                    Console.WriteLine(i);
                }
                cont = 0;
            }
            Console.ReadKey();
        }
    }
}
