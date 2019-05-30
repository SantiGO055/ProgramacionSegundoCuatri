using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero() : this(0)
        {
        }
        public Numero(double numero) : this (numero.ToString())
        {

        }
        public Numero(string numero)
        {
            SetNumero(numero);
        }

        private double ValidarNumero(string strNumero)
        {

            if (double.TryParse(strNumero, out double numeroDouble) == true)
            {
                return numeroDouble;
            }
            else
                return 0;

        }
        private void SetNumero(string numero)
        {
             this.numero = ValidarNumero(numero);
        }


        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            double NumAbsoluto = Math.Abs(numero);
            long cociente = (long)NumAbsoluto;
            long resto = (long)NumAbsoluto;

            while (cociente >= 1)
            {
                resto = cociente % 2;
                cociente = cociente / 2;

                if (resto != 0)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                else
                {
                    numeroBinario = "0" + numeroBinario;
                }
            }
            return numeroBinario;
        }

        public static string DecimalBinario(string numero)
        {

            double numeroAux;
            double.TryParse(numero, out numeroAux);
            return DecimalBinario(numeroAux);
        }


        public static string BinarioDecimal(string binario)
        {
            double NumeroDecimal = 0, binarioDouble, NumAbsoluto;
            int potencia = 1;
            string NumAbsolutoStr;

            binarioDouble = double.Parse(binario);
            NumAbsoluto = Math.Abs(binarioDouble);
            NumAbsolutoStr = Convert.ToString(NumAbsoluto);

            for (int i = NumAbsolutoStr.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    NumeroDecimal += potencia;
                }
                potencia *= 2;
            }
            NumAbsolutoStr = Convert.ToString(NumeroDecimal);
            return NumAbsolutoStr;
        }
        
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }

        }

        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

    }
}
