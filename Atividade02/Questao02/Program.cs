using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Qual é o maior número?---");
            Console.Write("Digite o 1º número: ");
            int num1 =int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            int num3 = int.Parse(Console.ReadLine());

            if(num1> num2 && num1 > num3)
            {
                Console.Write($"O maior é o {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write($"O maior é o {num2}");
            }
            else
            {
                Console.Write($"O maior é o {num3}");
            }
            Console.ReadKey();
        }
    }
}
