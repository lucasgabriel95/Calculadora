using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calcular
    {
        public float Resultado;

        public float Soma(float valor1,float valor2)
        {
            Resultado = valor1 + valor2;
            return Resultado;
        }

        public float  subitracao (float valor1,float valor2)
        {
            Resultado = valor1 - valor2;
            return Resultado;
        }
        
        public float Multiplicacao (float valor1,float valor2)
        { Resultado = valor1 * valor2; 
            return Resultado;
        }

        public float Divisao (float valor1,float valor2)
        {
            Resultado = valor1 / valor2;
            return Resultado;
        }

        public float Porcentagem(float valor1, float valor2)
        {
            Resultado = valor1 % valor2;
            return Resultado;
        }



    }
}
