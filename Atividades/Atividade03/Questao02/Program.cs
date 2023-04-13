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
            Console.WriteLine("\t\t---Cálculo de peso---");

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu sexo (1 para masculino e 2 para feminino): ");
            int sexo = Convert.ToInt32(Console.ReadLine());

            double peso;

            if(sexo < 1 && sexo > 2)
            {
                Console.WriteLine("Digite 1 para masculino e 2 para feminino");
            }
            else if(sexo == 1)
            {
                peso = (72.7 * altura) - 58.0;
                Console.WriteLine($"Você é um homem e seu peso ideal é {peso}");
            }
            else
            {
                peso = (62.1 * altura) - 44.7;
                Console.WriteLine($"Você é uma mulher e seu peso ideal é {peso}");
            }
            Console.ReadKey();
        }
    }
}
