using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO_APPLICATION
{
    public class Validacoes
    {
        public static bool ValorMaximo (double valor)
        {
            bool result = false;

            if (valor <= 1000000)
            {
                result = true;
            }

            return result;
        }

        public static bool ParcelaMinima (int parcela)
        {
            bool result = false;

            if (parcela >= 5)
            {
                result = true;
            }

            return result;
        }

        public static bool ParcelaMaxima (int parcela)
        {
            bool result = false;

            if (parcela <= 74 )
            {
                result = true;
            }

            return result;
        }

        public static bool ValorMinimoJuridica (double valor)
        {
            bool result = false;

            if (valor >= 15000)
            {
                result = true;
            }

            return result;
        }

        public static bool DataVencimentoMinima (DateTime date)
        {
            bool result = false;
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime d15 = dataAtual.AddDays(15);

            if (date >= d15)
            {
                result = true;
            }

            return result;
        }

        public static bool DataVencimentoMaxima(DateTime date)
        {
            bool result = false;
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime d40 = dataAtual.AddDays(40);

            if (date <= d40)
            {
                result = true;
            }


            return result;
        }

        public static double ValorTotalComJuros(double valor, int opcao, int parcela)
        {
            
            double valorFinal = 0;
            double valorJuros = 0;
            double valorParcela = 0;
            double valorParcelaJuros = 0;

            switch (opcao)
            {
                case 1:
                    valorJuros = valor * 0.02;
                    valorParcela = valor / parcela;
                    valorParcelaJuros = valorParcela + valorJuros;
                    valorFinal = valorParcelaJuros * parcela;
                    break;
                case 2:
                    valorJuros = valor * 0.01;
                    valorParcela = valor / parcela;
                    valorParcelaJuros = valorParcela + valorJuros;
                    valorFinal = valorParcelaJuros * parcela;
                    break;
                case 3:
                    valorJuros = valor * 0.05;
                    valorParcela = valor / parcela;
                    valorParcelaJuros = valorParcela + valorJuros;
                    valorFinal = valorParcelaJuros * parcela;
                    break;
                case 4:
                    valorJuros = valor * 0.03;
                    valorParcela = valor / parcela;
                    valorParcelaJuros = valorParcela + valorJuros;
                    valorFinal = valorParcelaJuros * parcela;
                    break;
                default:
                    valorJuros = (valor * 0.09) / 12;
                    valorParcela = valor / parcela;
                    valorParcelaJuros = valorParcela + valorJuros;
                    valorFinal = valorParcelaJuros * parcela;
                    break;
            }

            return valorFinal;
        }

    }
}
