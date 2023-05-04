using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\t\t--- RPG ---\n");
            System.Console.Write("Nome do Herói: ");
            string nomeHeroi = Console.ReadLine();
            Random random = new Random();
            int danoAleatorio = 0;
            int integrityHero = 10;
            int integrityMonster = 10;
            string vencedor = "";

            do
            {
                danoAleatorio = random.Next(1, 10);
                integrityMonster -= danoAleatorio;
                System.Console.WriteLine($"\nO monstro foi danificado e perdeu {danoAleatorio} saúde e agora tem {integrityMonster} saúde.");

                if (integrityMonster > 0)
                {
                    danoAleatorio = random.Next(1, 10);
                    integrityHero -= danoAleatorio;
                    System.Console.WriteLine($"O Herói foi danificado e perdeu {danoAleatorio} saúde e agora tem {integrityHero} saúde.");
                }

            }
            while (integrityMonster > 0 && integrityHero > 0);

            if (integrityHero > 0)
            {
                vencedor = "Herói " + nomeHeroi;
            }
            else
            {
                vencedor = "Monstro";
            }

            System.Console.WriteLine($"\nO {vencedor} é o vencedor");
        
        }
    }
}
