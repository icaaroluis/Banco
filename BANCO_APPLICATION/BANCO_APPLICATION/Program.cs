using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO_APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            bool sair = false;
            bool menu = false;
            bool valorMaximo = false;
            bool valorMinimoJuridica = false;
            bool valorValidation = false;
            bool parcelaMinima = false;
            bool parcelaMaxima = false;
            bool parcelaValidation = false;
            bool dataMinima = false;
            bool dataMaxima = false;
            bool dataValidation = false;
            double valorCredito = 0;
            double valorTotal = 0;
            int quantidadeParcela = 0; 
            int opcao = 0;

            while (sair == false)
            {
                while (menu == false)
                {
                    try
                    {
                        Menu.MenuOpcoes();
                        Console.WriteLine();
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao <= 5)
                        {
                            result = TipoCredito.Tipo(opcao);
                            menu = true;
                        }
                        else if (opcao == 6)
                        {
                            sair = true;
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Opção inválida, verifique as opções !!!");
                            Console.WriteLine();
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, verifique as opções !!!");
                        Console.WriteLine();
                    }
                }               

                Console.Clear();

                //Validação do valor que será recebido
                while (valorValidation == false)
                {
                    try
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine(result.ToUpper());

                        Console.WriteLine("Digite o valor do crédito:");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine();
                        valorCredito = Convert.ToDouble(Console.ReadLine());

                        valorMinimoJuridica = Validacoes.ValorMinimoJuridica(valorCredito);
                        valorMaximo = Validacoes.ValorMaximo(valorCredito);

                        if (opcao == 3 && valorMinimoJuridica == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");
                            Console.WriteLine("Valor minímo para Pessoa Jurídica é de R$15.000,00");
                            Console.WriteLine();

                        }
                        else if (valorMaximo == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");
                            Console.WriteLine("Valor maximo é de R$ 1.000.000,00");
                            Console.WriteLine();
                        }
                        else
                        {
                            valorValidation = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, verifique o formato que foi informado !!!");
                        Console.WriteLine();
                    }
                    
                }

                Console.Clear();
                //Validação do numero da parcela que será recebido
                while (parcelaValidation == false)
                {
                    try
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine(result.ToUpper());

                        Console.WriteLine("Digite a quantidade de parcela que deseja:");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine();
                        quantidadeParcela = Convert.ToInt32(Console.ReadLine());

                        parcelaMinima = Validacoes.ParcelaMinima(quantidadeParcela);
                        parcelaMaxima = Validacoes.ParcelaMaxima(quantidadeParcela);

                        if (parcelaMinima == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");

                            Console.WriteLine("Número minímo de parcela é de 5");
                            Console.WriteLine();
                        }
                        else if (parcelaMaxima == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");
                            Console.WriteLine("Número máximo de parcela é de 74");
                            Console.WriteLine();
                        }
                        else
                        {
                            parcelaValidation = true;
                        }

                        //Metodo para exibir o valor no final com detalhes
                        valorTotal = Validacoes.ValorTotalComJuros(valorCredito, opcao, quantidadeParcela);
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, verifique o formato que foi informado !!!");
                        Console.WriteLine();
                    }
                    

                }

                Console.Clear();
                //Validação da data que será recebido
                while (dataValidation == false)
                {
                    try
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine(result.ToUpper());


                        Console.WriteLine("Digite a data do primeiro vencimento:");
                        Console.WriteLine("Formato " + DateTime.Now.ToShortDateString());
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine();
                        DateTime dataVencimento = Convert.ToDateTime(Console.ReadLine());

                        dataMinima = Validacoes.DataVencimentoMinima(dataVencimento);
                        dataMaxima = Validacoes.DataVencimentoMaxima(dataVencimento);

                        if (dataMinima == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");
                            Console.WriteLine("A data miníma para vencimento é D+15");
                            Console.WriteLine();
                        }
                        else if (dataMaxima == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("- - - - - - - Crédito Reprovado - - - - - - - - ");
                            Console.WriteLine("A data máxima para vencimento é D+40");
                            Console.WriteLine();
                        }
                        else
                        {
                            dataValidation = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, verifique o formato que foi informado !!!");
                        Console.WriteLine();
                    }                   

                }

                Console.Clear();
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("- - - - - - -  CRÉDITO APROVADO - - - - - - - - ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("O valor total do crédito é de R$" + Math.Round(valorTotal,2));
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("O valor total do juros é de R$" + Math.Round((valorTotal - valorCredito),2));

                valorMaximo = false;
                valorMinimoJuridica = false;
                valorValidation = false;
                parcelaMinima = false;
                parcelaMaxima = false;
                parcelaValidation = false;
                dataMinima = false;
                dataMaxima = false;
                dataValidation = false;
                menu = false;

                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}
