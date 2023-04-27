using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForQuestao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 10; i++)
            {
                Console.Clear();
                Console.WriteLine("\t\t---Realjuste Salarial---");
                Console.Write($"\nSalário do {i}º funcionário: ");
                double salario = double.Parse(Console.ReadLine());
                

                if (salario < 1000)
                {
                    double reajuste = salario * 0.55;
                    double novosalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---"); 
                    Console.WriteLine($"Salario atual: {salario:c2}");
                    Console.WriteLine($"Reajuste: {reajuste:c2}");
                    Console.WriteLine($"Novo Salario: {novosalario:c2}");
                
                }
                else if(salario < 2500)
                {
                    double reajuste = salario * 0.30;
                    double novosalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine($"Salario atual: {salario:c2}");
                    Console.WriteLine($"Reajuste: {reajuste:c2}");
                    Console.WriteLine($"Novo Salario: {novosalario:c2}");
                
                }
                else
                {
                    double reajuste = salario * 0.20;
                    double novosalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine($"Salario atual: {salario:c2}");
                    Console.WriteLine($"Reajuste: {reajuste:c2}");
                    Console.WriteLine($"Novo Salario: {novosalario:c2}");
                
                }
               Console.ReadKey(); 
            }
            
        }
    }
}
