using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connString = "Data Source=.\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            object[][] wynik = pzb.WykonajZapytanie("select imie, nazwisko, kraj from zawodnicy");

            for (int i = 0; i < wynik.Length; i++)
                Console.WriteLine(String.Join(" ", wynik[i]));

            Console.ReadKey();
        }
    }
}