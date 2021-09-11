using System;

namespace Entidades
{
    public class Calculadora
    {
        #region metodos
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;
            char operadorValidado;
            operadorValidado = ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':

                    retorno = num1 / num2;
                    break;
                default:
                    retorno = 0; 
                    break;
            }
            return retorno;
        }


        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador;
            }
            return retorno;
        }

        public static char Conversor(int numero)
        {
            char retorno;
            switch (numero)
            {
                case 0:
                    retorno = '+';
                    break;
                case 1:
                    retorno = '-';
                    break;
                case 2:
                    retorno = '*';
                    break;
                case 3:
                    retorno = '/';
                    break;
                default:
                    retorno = '+';
                    break;
            }
            return retorno;
        }
        #endregion

    }
}
