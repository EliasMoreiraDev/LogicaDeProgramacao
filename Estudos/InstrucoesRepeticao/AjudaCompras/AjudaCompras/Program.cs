using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--- Ajuda nas Compras");
            Console.Write("Informe o valor disponível:");
            double saldo = double.Parse(Console.ReadLine());
             double compra = 0;
            double somacompras=0;
            int cont = 0;
            bool podeComprar = true;

            do
            {
                Console.WriteLine("\nValor compra: ");
                compra = double.Parse(Console.ReadLine());
                if (compra > 0)
                {
                    if (compra < saldo)
                    {
                        saldo -= compra;
                        somacompras += compra;
                        cont++;
                        Console.WriteLine("Compra concluída!!!");
                        Console.WriteLine($"Saldo disponível: {saldo.ToString("c2")}");
                    }
                    else
                    {
                        Console.WriteLine("A compra é maior que seu saldo disponível :( fazuele");
                        podeComprar = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nValor inválido");
                    
                    
                }
            }while(podeComprar);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            
            Console.WriteLine("\t\t---Resultado das compras---");
            Console.WriteLine($"\nNúmero de compra: {cont}\nValor gasto: {somacompras:c2}\nSaldo Restante: {saldo:c2}");
        }
    }
}
