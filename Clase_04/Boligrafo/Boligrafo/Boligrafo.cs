+using System;
using System.Collections.Generic;
using System.Text;

namespace Boligrafo
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        short tinta;
        ConsoleColor color;
        public void Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public getColor(ConsoleColor color)
        {
            return this.color;
        }
        public getTinta(shot tinta)
        {
            return this.tinta;
        }
        private void setTinta(short tinta)
        {
            if(tinta>=0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar(short tinta)
        {
            this.tinta = cantidadTintaMaxima;
        }
    }
}
