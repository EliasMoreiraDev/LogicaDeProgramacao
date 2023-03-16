using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Nome maior---");
            Console.Write("Digite o primeiro nome: ");
            String nome1 = Console.ReadLine();
            Console.Write("Digite o segundo nome: ");
            String nome2 = Console.ReadLine();

            if(nome1.Length > nome2.Length)
            {
                Console.WriteLine($"O primeiro nome {nome1} tem {nome1.Length} e é maior que o segundo nome {nome2} que tem {nome2.Length}");
            }
            else
            {
                Console.WriteLine($"O segundo nome {nome2} tem {nome2.Length} e é maior que o primeiro nome {nome1} que tem {nome1.Length}");
            }
            Console.ReadKey();
        }
    }
}
