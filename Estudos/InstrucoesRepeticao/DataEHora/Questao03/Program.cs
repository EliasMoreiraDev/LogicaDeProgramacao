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

            Console.Write("Data de Nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            CalcularIdadeDetalhada(dataNasc);
            Console.ReadKey();
        }
        static void CalcularIdadeDetalhada(DateTime dtNascimento)
        {
            DateTime dataAtual = DateTime.Now;
            
            TimeSpan diferenca = dataAtual - dtNascimento;
            DateTime idade = DateTime.MinValue + diferenca;

            int ano = idade.Year - 1;
            int mes = idade.Month - 1;
            int dia = idade.Day - 1;

            Console.WriteLine($"Sua idade é {ano} anos, {mes} meses e {dia} dias");
        }
    }
}
