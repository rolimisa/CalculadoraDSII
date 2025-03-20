using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Dividir(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Erro: Divisão por zero não permitida.");
            }
        }
    }
}
