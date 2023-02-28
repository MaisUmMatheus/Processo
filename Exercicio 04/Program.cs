using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double Outros = 19849.53;

            double soma_faura = sp + rj + mg + es + Outros;

            double percentualsp = (sp / soma_faura) * 100;
            double percentualrj = (rj / soma_faura) * 100;
            double percentualmg = (mg / soma_faura) * 100;
            double percentuales = (es / soma_faura) * 100;
            double percentualoutros = (Outros / soma_faura) * 100;

  

            Console.WriteLine("A soma da fatura total é:" + soma_faura);
            Console.WriteLine($"O percentual de SP:" + Math.Round(percentualsp, 2)+ "%, percentual de RJ:"+ Math.Round(percentualrj, 2)+ "%, percentual de MG:"+Math.Round(percentualmg, 2)+ "%, percentual de ES:" + Math.Round(percentuales, 2)+ "% e\n percentual de Outros:" + Math.Round(percentualoutros, 2)+"%");




            Console.WriteLine("DE ENTER PARA CONTINUAR");
            Console.ReadLine(); 



            
            



        }
    }
}
