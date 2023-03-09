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
            string nome, end, telefone;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu endereço: ");
            end = Console.ReadLine();
            Console.Write("Digite seu telefone: ");
            telefone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Seu nome é {nome}, seu endereço é {end} e seu telefone é {telefone}!");
            Console.ReadKey();

        }
    }
}
