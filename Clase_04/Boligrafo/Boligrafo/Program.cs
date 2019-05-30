using System;

namespace Boligrafo
{
    class Program
    {
        short tintaA;
        short tintaR;
        static void Main(string[] args)
        {
            Boligrafo boligrafo = new Boligrafo;
            boligrafo.Boligrafo(tinta,ConsoleColor.Blue);
            boligrafo.Recargar(tinta,100);
            boligrafo.Boligrafo(tinta, ConsoleColor.Red);

        }
    }
}
