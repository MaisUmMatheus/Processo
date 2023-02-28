using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string palavra; 


        Console.WriteLine("Escreva a palavra:");
        palavra = Console.ReadLine();

       
        char[] inverter = palavra.ToCharArray(); 

            for (int i = 0, j = inverter.Length - 1; i < j; i++, j--) 
            {
                char Aux = inverter[i]; 
                inverter[i] = inverter[j]; 
                inverter[j] = Aux; 
            }

        string palavra_invertida = new string(inverter); 
        Console.WriteLine(palavra_invertida);


        Console.WriteLine("DE ENTER PARA CONTINUAR");
        Console.ReadLine();
        }
    }
}
