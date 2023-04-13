using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrucoesRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while(op == 1)
            { 
                Console.WriteLine("\t\t--- Calculadora com While ---\n");
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                int cont = 0;

                while (cont <= 10)
                {

                    Console.WriteLine($"{num} x {cont} = {num * cont}");
                    cont++;
                }
                Console.WriteLine("Deseja efetuar outra operação? [0] Não; [1] Sim");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            


            Console.ReadKey();


        }
    }
}
