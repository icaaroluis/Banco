using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO_APPLICATION
{
    public class Menu
    {
        public static void MenuOpcoes()
        {
            Console.WriteLine("BANCO - SETOR DE EMPRÉSTIMOS");
            Console.WriteLine();
            Console.WriteLine("Escolha a opção desejada");
            Console.WriteLine("1 - Crédito Direto (Taxa de 2% ao mês)");
            Console.WriteLine("2 - Crédito Consignado (Taxa de 1% ao mês)");
            Console.WriteLine("3 - Crédito Pessoa Jurídica (Taxa de 5% ao mês)");
            Console.WriteLine("4 - Crédito Pessoa Física (Taxa de 3% ao mês)");
            Console.WriteLine("5 - Crédito Imobiliário (Taxa de 9% ao ano)");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        }
    }
}
