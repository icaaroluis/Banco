using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO_APPLICATION
{
    public class TipoCredito
    {
        
        public static string Tipo(int opcao)
        {
            string result = "";

            switch (opcao)
            {
                case 1:
                    result = "Crédito Direto";
                    break;
                case 2:
                    result = "Crédito Consignado";
                    break;
                case 3:
                    result = "Crédito Pessoa Jurídica";
                    break;
                case 4:
                    result = "Crédito Pessoa Física";
                    break;
                default:
                    result = "Crédito Imobiliário";
                    break;
            }

            return result;
        }
    }
}
