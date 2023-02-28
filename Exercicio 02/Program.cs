using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 1;

            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if (c == numero)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        Console.WriteLine("De enter para finalizar");
        Console.ReadLine();

        }
    }
}
