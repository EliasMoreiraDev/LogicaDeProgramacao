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
            Console.WriteLine("\t\t---Reajuste de Salário---");

            Console.Write("Salário atual: ");
            int salarioAtual = Convert.ToInt32(Console.ReadLine());

            double reajuste;

            if(salarioAtual < 1500)
            {
                reajuste = salarioAtual + (salarioAtual*0.23); 
            }
            else
            {
                reajuste = salarioAtual + (salarioAtual * 0.18);
            }
            Console.WriteLine($"O salario reajustado é igual a {reajuste.ToString("c2")}");
            Console.ReadKey();

        }
    }
}
