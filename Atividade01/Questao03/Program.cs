using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, mediaIdade = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a {i + 1}° idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                mediaIdade += idade;
            }
            Console.WriteLine($"A média das idades é {mediaIdade / 5}!");
            Console.ReadKey();
        }
    }
}
