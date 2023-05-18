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
            Console.WriteLine("Digite sua data de nascimento |dd/MM/yyy|");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dataNasc.Year;
            Console.WriteLine("Voce tem: " + (idade) + " anos de idade");

        }
    }
}
