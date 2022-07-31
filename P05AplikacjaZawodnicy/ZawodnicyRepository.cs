﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    internal class ZawodnicyRepository
    {
        private string connString = "Data Source=.\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        public Zawodnik[] WczytajZawodnikow(string filtr)

        {
            string sql = $"select * from zawodnicy where kraj like '%{filtr}%'" +
                $" or imie like '%{filtr}%'  " +
                $" or nazwisko like '%{filtr}%'  ";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik = pzb.WykonajZapytanie(sql);

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik ityZawodnik = new Zawodnik();

                ityZawodnik.Id_zawodnika = (int)wynik[i][0];
                ityZawodnik.Imie = (string)wynik[i][2];
                ityZawodnik.Nazwisko = (string)wynik[i][3];
                ityZawodnik.Kraj = (string)wynik[i][4];
                ityZawodnik.DataUr = (DateTime)wynik[i][5];
                ityZawodnik.Wzrost = (int)wynik[i][6];
                ityZawodnik.Waga = (int)wynik[i][7];

                zawodnicy[i] = ityZawodnik;
            }

            return zawodnicy;
        }

        public void Edytuj(Zawodnik z)
        {
            string sql = "update zawodnicy set imie='{0}', nazwisko='{1}', kraj='{2}', data_ur='{3}', wzrost={4}, waga={5} where id_zawodnika={6}";

            sql = string.Format(sql, z.Imie, z.Nazwisko, z.Kraj, z.DataUr.ToString("yyyy-MM-dd"), z.Wzrost, z.Waga, z.Id_zawodnika);

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sql);
        }
    }
}