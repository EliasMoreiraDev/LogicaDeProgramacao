using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite seu nome: ");
                nomes[i] = Console.ReadLine();

            }

            Console.Clear();
            Console.WriteLine("Nomes digitados\n");

            for (int j = 0; j < nomes.Length; j++)
            {
                Console.WriteLine(nomes[j]);
            }
            Console.ReadKey();
        }
    }
}
