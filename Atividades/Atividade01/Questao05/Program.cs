using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quanto você andou em Km: ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível em Litros: ");
            int litros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Você andou {km / litros}km com 1 litro de combustível.");
        }
    }
}
