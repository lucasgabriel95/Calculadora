using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Controle
    {
        public float ResultadoFinal; 
        public float operacao (string operacao,float valor1, float valor2)
        {
            Calcular cl = new Calcular();
            switch (operacao)
            {
                case "+":
                    cl.Soma(valor1,valor2);
                    break;
                case "-":
                    cl.subitracao(valor1,valor2);
                    break;
                case "*":
                    cl.Multiplicacao(valor1,valor2);
                    break;
                case "/":
                    cl.Divisao(valor1, valor2);
                    break;
                case "%":
                    cl.Divisao(valor1, valor2);
                    break;
            }
            ResultadoFinal = cl.Resultado;
            return ResultadoFinal;
        }
    }
}
