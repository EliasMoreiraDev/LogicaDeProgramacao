using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);

            string hora = DateTime.Now.ToShortTimeString();
            Console.WriteLine("\nHora: " + hora);

            string data = DateTime.Now.ToShortDateString();
            Console.WriteLine("data: " + data);

            DateTime dt = DateTime.Now;
            string dataFormatada = dt.ToString("dd/MM/yyy");
            Console.WriteLine(dataFormatada);

            DateTime dtOntem = DateTime.Now.AddDays(-1);
            DateTime dtAmanha = DateTime.Now.AddDays(1);

            TimeSpan diferenca = dtAmanha - dtOntem;
            int dtdiferenca = diferenca.Days;

            Console.WriteLine("TimesSpan: "+ diferenca);
            Console.WriteLine("Diferenca: " + dtdiferenca);


        }
    }
}
