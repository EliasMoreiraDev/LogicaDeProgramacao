using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForQuestao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
               Console.Clear();
                Console.Write("Nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.Write("Salario bruto: ");
                double salariobruto = double.Parse(Console.ReadLine());

                double imposto = 0;
                if (salariobruto < 1000)
                {
                    Console.WriteLine("Você esta insento de imposto");

                }
                else if(salariobruto < 1500)
                {
                    imposto = salariobruto * 0.075;
                    Console.WriteLine($"O funcionario {nome} pagará {imposto:c2} de imposto");
                    
                }
                else
                {
                    imposto = salariobruto * 0.15;
                    Console.WriteLine($"O funcionario {nome} pagará {imposto:c2} de imposto");
                    
                }
                Console.ReadKey();
            }
        }
    }
}
