using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class  Calculos
    {
        double resultado = 0;

        public double soma(int a , int b) {
            resultado = a + b;
            return resultado;
        }
        public double subtracao(int a, int b)
        {
            resultado = a - b;
            return resultado;
        }
        public double divisao(int a, int b)
        {
            resultado = a / b;
            return resultado;
        }
        public double multiplicao(int a, int b)
        {
            resultado = a * b;
            return resultado;
        }
    }
}
