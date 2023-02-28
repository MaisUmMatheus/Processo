using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Ainda não sei fazer uma API estou estudando para isso, mas para não deixar em branco está aqui.
 * Obrigado pela Atenção.
 */
namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] vetor = new double[31];
            double somar_faturamento = 0;
            double maior = vetor[0], menor = vetor[0];
            int i = 1;
            double faturamento_médio = 0;
            double media = 0;
            double dias = 0;

            vetor[1] = 22174.1664;
            vetor[2] = 24537.6698;
            vetor[3] = 26139.6134;
            vetor[6] = 26742.6612;
            vetor[8] = 42889.2258;
            vetor[9] = 46251.174;
            vetor[10] = 11191.4722;
            vetor[13] = 3847.4823;
            vetor[14] = 373.7838;
            vetor[15] = 2659.7563;
            vetor[16] = 48924.2448;
            vetor[17] = 18419.2614;
            vetor[20] = 35240.1826;
            vetor[21] = 43829.1667;
            vetor[22] = 18235.6852;
            vetor[23] = 4355.0662;
            vetor[24] = 13327.1025;
            vetor[27] = 25681.8318;
            vetor[28] = 1718.1221;
            vetor[29] = 13220.495;
            vetor[30] = 8414.61;


            for (i = 0; i < vetor.Length; i++)
            {
                somar_faturamento += vetor[i];

                faturamento_médio = somar_faturamento;
                media = faturamento_médio / 21;

                if (vetor[i] > media)
                {
                    Console.WriteLine("Dias que o faturamento superou a média:" + i);
                }

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    i++;
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    i++;
                }

            }

            Console.WriteLine("Maior Faturamento ocorrido foi:" + maior);
            Console.WriteLine("Menor Faturamento ocorrido foi:" + menor);
            Console.ReadLine();

        }
    }
}
