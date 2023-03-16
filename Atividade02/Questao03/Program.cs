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
            Console.WriteLine("\t\t---Aprovado ou Reprovado---");
            Console.Write("Nome do aluno(a): ");
            String nome = Console.ReadLine();
            Console.Write("Digite a 1° nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2° nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3° nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4° nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4)/4;   

            if(media > 6.0)
            {
                Console.WriteLine($"Olá {nome}, sua média foi {media}. PARABÉNS VOCÊ FOI APROVADO");
            }
            else
            {
                Console.WriteLine($"Olá {nome}, sua média foi {media}. SINTO  MUITO VOCÊ FOI REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
