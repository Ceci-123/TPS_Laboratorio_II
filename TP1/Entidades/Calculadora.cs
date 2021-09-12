using System;

namespace Entidades
{
    public class Calculadora
    {
        #region metodos
        /// <summary>
        /// Realiza la operacion suma, resta, multiplicacion o division entre los numeros
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador">que operacion se va a realizar</param>
        /// <returns>Devuelve el resultado de la operacion </returns>
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

        /// <summary>
        /// Valida que el operador sea + - * /
        /// </summary>
        /// <param name="operador">El char a validar</param>
        /// <returns>El operador si es valido, o + por default</returns>
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
