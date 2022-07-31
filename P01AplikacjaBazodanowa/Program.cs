using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SqlConnection connection; // do nawiązania polaczenia z bazą
            SqlCommand command; // przechowuje polecenia SQL
            SqlDataReader sqlDataReader; // czytanie wyników z tabelki

            string connString = "Data Source=.\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            connection = new SqlConnection(connString);

            command = new SqlCommand("select * from zawodnicy", connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader(); // wysyła polecenie do bazy danych

            //bool czyKoniec= sqlDataReader.Read();

            //string wynik = (string)sqlDataReader.GetValue(2);

            //Console.WriteLine(wynik);

            //sqlDataReader.Read();
            //wynik = (string)sqlDataReader.GetValue(2);
            //Console.WriteLine(wynik);

            while (sqlDataReader.Read())
            {
                string wynik = (string)sqlDataReader.GetValue(2) + " " + (string)sqlDataReader.GetValue(3);
                Console.WriteLine(wynik);
            }

            connection.Close();

            Console.ReadKey();
        }
    }
}