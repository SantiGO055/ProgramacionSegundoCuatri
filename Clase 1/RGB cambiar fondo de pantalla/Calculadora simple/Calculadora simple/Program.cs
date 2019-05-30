using System;

namespace Calculadora_simple
{
    class Program
    {
        static int primerNumero;
        static int segundoNumero;
        static int operador;

        static void Main(string[] args)
        {
            Console.WriteLine("\tMenu: \n");
            Console.WriteLine("Ingrese un numero: \n");
            int.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Ingrese otro numero: \n");
            int.TryParse(Console.ReadLine(), out segundoNumero);
            System.Console.Clear();
            Console.WriteLine("\t1 - SUMAR: \n");
            Console.WriteLine("\t2 - RESTAR: \n");
            Console.WriteLine("\t3 - MULTIPLICAR: \n");
            Console.WriteLine("\t4 - DIVIDIR: \n");
            int.TryParse(Console.ReadLine(), out operador);
            miSwitch(operador, primerNumero, segundoNumero);

            Console.ReadKey();
            
        }
        static void miSwitch(int operador, int primerNumero, int segundoNumero)
        {
            Console.WriteLine("Resultado:");
            switch (operador)
            {
                case 1:
                    {
                        Console.WriteLine(primerNumero + segundoNumero);

                        System.Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(primerNumero - segundoNumero);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(primerNumero * segundoNumero);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(primerNumero / segundoNumero);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

    }


}
