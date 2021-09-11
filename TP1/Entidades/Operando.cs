using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;  // atributo

        #region constructores
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }
        public Operando(string strNumero) : this()
        {
            this.numero = double.Parse(strNumero);
            //this.SetNumero = strNumero;   controlar esto
        }

        #endregion
        //setter
        public void SetNumero(string strNumero)
        {
            this.numero = ValidarOperando(strNumero);
        }

        #region metodos

        public static string BinarioDecimal(string binario)
        {
            return " ";
        }

        public static string DecimalBinario(double numero)
        {
            return " ";
        }

        public static string DecimalBinario(string numero)
        {
            return " ";
        }

        private static bool EsBinario(string binario)
        {
            return true;
        }

        #region sobrecarga de operadores 
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = 0;
            retorno = n1.numero - n2.numero;
            return retorno;

        }
        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = 0;
            retorno = n1.numero + n2.numero;
            return retorno;

        }
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = 0;
            retorno = n1.numero * n2.numero;
            return retorno;

        }
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = 0;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }

            return retorno;

        }

        #endregion
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            //aca falta alguna otra validacion????
            retorno = double.Parse(strNumero);
            return retorno;
        }
        #endregion

    }
}
