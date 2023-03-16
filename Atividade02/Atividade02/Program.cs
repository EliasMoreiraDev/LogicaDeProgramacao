using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica de um número é par ou impar");
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num != 0)
            {
                Console.WriteLine($"O número {num} é par");
            }
            else if (num == 0)
            {
                Console.WriteLine("O número é neutro");
            }
            else
            {
                Console.WriteLine($"O número {num} é impar");
            }
            Console.ReadKey();
        }
    }
}
