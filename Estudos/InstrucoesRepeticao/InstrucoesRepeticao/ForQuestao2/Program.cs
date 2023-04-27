using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForQuestao2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t---Converte Celsius e Fahrenheit---");
            Console.Write("\nTemperatura mínima em Fahrenheit: ");
            int valorMinimo = int.Parse(Console.ReadLine());
            Console.Write("\nTemperatura máxima em Fahrenheit: ");
            int valorMaximo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o valor da escala: ");
            int incremento = int.Parse(Console.ReadLine());
            Console.Clear();
            for (; valorMinimo <= valorMaximo; valorMinimo+=incremento)
            {
                
                int c = (5 * (valorMinimo - 32)) / 9;
                Console.WriteLine($"O valor em Fahrenheit é {valorMinimo}\nValor em Celcius é {c}");
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();
        }
    }
}
