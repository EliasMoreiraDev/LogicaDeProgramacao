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
            Console.WriteLine("\t\t---Simulador de conta corrente---");
            Console.WriteLine("[1] Depositar\n[2] Sacar\n[3] Exibir saldo\n[4] Sair");
            int action = 0;
            int saldo = 0;

            while(action != 4)
            {
                if (action == 0)
                {
                    Console.Write("Oque deseja fazer? ");
                    action = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                if (action == 1)
                {

                    Console.Write("Valor a depositar: R$");
                    int deposito = int.Parse(Console.ReadLine());
                    if (deposito <= 0)
                    {
                        Console.WriteLine("O valor deve ser maior que R$0\n");
                        
                    }
                    else
                    {
                        saldo += deposito;
                        Console.WriteLine("Valor depositado com sucesso!\n");
                        
                    }
                    
                    action = 0;
                }
                
                if(action == 2)
                {
                    if (saldo == 0)
                    {
                        Console.WriteLine("Você não tem saldo! Deposite um valor para sacar\n");
                    }
                    else
                    {
                        Console.Write("Valor a sacar: R$");
                        int saque = int.Parse(Console.ReadLine());
                        
                        if (saque > saldo)
                        {
                            Console.WriteLine("Valor a digitado maior do que o saldo disponivel!\n");
                           
                        }
                        else
                        {
                            if (saque <= 0)
                            {
                                Console.WriteLine("O valor deve ser maior que R$0\n");

                            }
                            else
                            {
                                saldo -= saque;
                                Console.WriteLine("Valor sacado com sucesso!\n");

                            } 
                        }
                    }
                    action = 0;

                }
                if(action == 3)
                {
                    Console.WriteLine("Seu valor disponível é R$" + saldo+"\n");
                    action = 0;
                }
                
            }
            
        }
    }
}
