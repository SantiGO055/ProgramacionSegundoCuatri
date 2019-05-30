using System;

namespace guiaEjerciciosProgII
{
    class Ejercicio_01
    {
        static int numero;
        static int flag;
        static int max;
        static int min;
        static int cont;

        public static int Cont { get => cont; set => cont = value; }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            //System.Console.ReadKey();
            

            do {
                Console.WriteLine("Ingrese un numero");

                int.TryParse(Console.ReadLine(), out numero);
                    if (flag == 0 || numero > max)
                    {
                    max = numero;
                    
                    }
                if (flag == 0 || numero < min)
                {
                    min = numero;
                    flag = 1;
                }
                Cont++;
            } while (Cont<5);

            
            Console.WriteLine("El numero maximo es el {0} y el minimo es {1}",max,min);
            System.Console.ReadKey();

        }
    }
}
