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
            Console.WriteLine("\t\t---Calcula Idade---");
            Console.WriteLine("| Digite sua data de nascimento |");
            Console.Write("DIA: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("MES: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("ANO: ");
            int ano = int.Parse(Console.ReadLine());
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - ano;
            Console.WriteLine("Voce tem: " + (idade) + " de idade");

        }
    }
}
