using System;

namespace ConsoleApp2
{
    class Program
    {
        static int miEntero;
        static char miTecla;
        //static bool miBoolean;


        static void Main(string[] args)
        {
            Console.WriteLine("Presione la tecla r para cambiar el fondo a rojo: \n");
            Console.WriteLine("Presione la tecla g para cambiar el fondo a verde: \n");
            Console.WriteLine("Presione la tecla b para cambiar el fondo a azul: \n");
            
            do
            {
                miTecla = System.Console.ReadKey().KeyChar;
                switch (miTecla)
                {
                    case 'r':
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            break;
                        }
                    case 'g':
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            break;
                        }
                    case 'b':
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (miTecla == 'r' || miTecla == 'g' || miTecla == 'b');
        }


    }

}

            
        
    

