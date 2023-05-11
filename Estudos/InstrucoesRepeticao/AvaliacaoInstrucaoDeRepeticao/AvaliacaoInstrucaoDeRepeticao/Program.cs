using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoInstrucaoDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elias Moreira dos Santos | Yan Fernando Lobato
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t---Calcula Área---");
                Console.WriteLine("\n[1] Retagulo\n[2] Círculo\n[3] Triângulo\n[4] Sair\n");
                Console.Write("Forma geometrica que deseja calcular a área: ");
                int formaGeo = int.Parse(Console.ReadLine());
                double area;

                switch (formaGeo)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\t\t---Calcular área do Retângulo---\n\n");
                        Console.Write("Digite a largura: ");
                        double largura = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        if (largura <= 0 || altura <= 0)
                        {
                            Console.WriteLine("Alguma medida esta com valor negativo. Digite um valor válido!");
                            Console.ReadKey();
                            continue;
                        }
                        area = largura * altura;
                        Console.WriteLine($"\nA área do retângulo é {area}.\n");
                        Console.Write("ENTER para continuar!");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t\t---Calcular area do Círculo---\n\n");
                        Console.Write("Digite o raio: ");
                        double raio = double.Parse(Console.ReadLine());
                        if (raio <= 0)
                        {
                            Console.WriteLine("O raio está com valor negativo. Digite um valor válido!");
                            Console.ReadKey();
                            continue;
                        }
                        area = 3.1415 * (raio * raio);
                        Console.Write($"\nA área do círculo é {area}.\n\nENTER para continuar!");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\t\t---Calcular área do Triângulo---\n\n");
                        Console.Write("Digite a largura: ");
                        largura = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());
                        if (largura <= 0 || altura <= 0)
                        {
                            Console.WriteLine("Alguma medida esta com valor negativo. Digite um valor válido!");
                            Console.ReadKey();
                            continue;
                        }
                        area = (largura * altura) / 2;
                        Console.Write($"\nA área do triângulo é {area}.\n\nENTER para continuar!");
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}