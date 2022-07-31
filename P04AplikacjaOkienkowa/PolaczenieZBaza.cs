using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaOkienkowa
{
    internal class PolaczenieZBaza
    {
        private string connString;

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public object[][] WykonajZapytanie(string sql)
        {
            SqlConnection connection; // do nawiązania polaczenia z bazą
            SqlCommand command; // przechowuje polecenia SQL
            SqlDataReader sqlDataReader; // czytanie wyników z tabelki

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader(); // wysyła polecenie do bazy danych

            // mogę sprawdzić ile komumn mam do dyspozycji
            int liczbaKolumn = sqlDataReader.FieldCount;

            // tworzmy listę (bo nie znamy ostatneczej liczby wierszy). to jest lista komórek
            List<object[]> listaWierszy = new List<object[]>();

            while (sqlDataReader.Read())
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = sqlDataReader.GetValue(i);

                listaWierszy.Add(komorki);
            }

            connection.Close();

            return listaWierszy.ToArray();
        }
    }
}