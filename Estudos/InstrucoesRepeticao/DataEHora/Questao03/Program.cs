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
            DateTime dataAtual = DateTime.Now;
            Console.Write("Data de Nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());

            int ano = dataAtual.Year - dataNasc.Year;
            int mes = dataAtual.Month - dataNasc.Month;
            int dia = dataAtual.Day - dataNasc.Day;

            Console.WriteLine($"Sua idade é {ano} anos, {mes} meses e {dia} dias");
            
        }
    }
}
