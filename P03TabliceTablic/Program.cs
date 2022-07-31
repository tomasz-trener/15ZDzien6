using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TabliceTablic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] tablicaJednoWym = new string[3] { "ala", "ma", "kota" };

            string[,] tablicaDwuWym = new string[2, 3];
            tablicaDwuWym[0, 0] = "1";
            tablicaDwuWym[0, 1] = "2";
            tablicaDwuWym[0, 2] = "3";

            tablicaDwuWym[1, 0] = "4";
            tablicaDwuWym[1, 1] = "5";
            tablicaDwuWym[1, 2] = "6";

            for (int i = 0; i < tablicaDwuWym.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuWym.GetLength(1); j++)
                {
                    Console.Write(tablicaDwuWym[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------");

            for (int i = 0; i < tablicaDwuWym.GetLength(1); i++)
            {
                for (int j = 0; j < tablicaDwuWym.GetLength(0); j++)
                {
                    Console.Write(tablicaDwuWym[j, i]);
                }
                Console.WriteLine();
            }

            // tablice postrzepione (tablice tablic)
            // jagged array

            string[][] tablicaTablic = new string[3][];

            tablicaTablic[0] = new string[2];
            tablicaTablic[1] = new string[3];
            tablicaTablic[2] = new string[1];

            tablicaTablic[0][0] = "1";
            tablicaTablic[0][1] = "2";

            tablicaTablic[1][0] = "3";
            tablicaTablic[1][1] = "4";
            tablicaTablic[1][2] = "5";

            tablicaTablic[2][0] = "6";

            Console.WriteLine("-------");

            for (int i = 0; i < tablicaTablic.Length; i++)
            {
                Console.WriteLine(String.Join(" ", tablicaTablic[i]));
            }

            Console.ReadKey();
        }
    }
}