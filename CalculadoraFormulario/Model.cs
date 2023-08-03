using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFormulario
{
    internal class model
    {
    
            private double operacao;
            public model()
            {
                ConsultarOperacao = 0;
            }//fim do construtor

            public double ConsultarOperacao
            {
                get { return operacao; }
                set { this.operacao = value; }
            }//fim do método
            public double Somar(double num)
            {
                return ConsultarOperacao += num;
            }//fim do somar

            public double Subtrair(double num)
            {
                return ConsultarOperacao -= num;
            }//fim do subtrair

            public double Dividir(double num)
            {
                return ConsultarOperacao /= num;
            }//fim do div

            public double Multiplicar(double num)
            {
                return ConsultarOperacao *= num;
            }//fim do mult

            public double Potencia(double num)
            {
                double expoente = Convert.ToDouble(Console.ReadLine());

                return ConsultarOperacao = Math.Pow(num,expoente);
            
            }//fim do mult

            public double Raiz(double num)
            {
                 return ConsultarOperacao = Math.Sqrt(num);

        }//fim do mult
        
    }
}
