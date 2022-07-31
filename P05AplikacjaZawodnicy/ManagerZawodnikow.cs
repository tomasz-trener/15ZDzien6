using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    public class ManagerZawodnikow
    {
        private string kraj;
        private Zawodnik[] wczytaniZawodnicy;
        private Zawodnik[] wszyscyZawodnicy;
        private string sciezka;
        private Sortowanie kierunekSortowania;

        public Sortowanie KierunekSortowania => kierunekSortowania;

        public Zawodnik[] WczytaniZawodnicy => wczytaniZawodnicy;

        public ManagerZawodnikow(string kraj, string sciezka)
        {
            this.sciezka = sciezka;
            this.kraj = kraj;
        }

        public Zawodnik[] Wczytaj(string[] wiersze)
        {
            // Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length-1];
            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            wszyscyZawodnicy = new Zawodnik[wiersze.Length - 1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik(komorki, this);
                //z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                //z.Id_trenera = Convert.ToInt32(komorki[1]);
                //z.Imie = komorki[2];
                //z.Nazwisko = komorki[3];
                //z.Kraj = komorki[4];
                //z.DataUr = Convert.ToDateTime(komorki[5]);
                //z.Wzrost = Convert.ToInt32(komorki[6]);
                //z.Waga = Convert.ToInt32(komorki[7]);

                //zawodnicy[i - 1] = z;
                if (kraj.ToLower() == z.Kraj.ToLower())
                    zawodnicy.Add(z);

                wszyscyZawodnicy[i - 1] = z;
            }
            wczytaniZawodnicy = zawodnicy.ToArray();
            return wczytaniZawodnicy;
        }

        internal void StworzNowego(Zawodnik zawodnik)
        {
            List<Zawodnik> wszyscyZawodnicyLista = wszyscyZawodnicy.ToList();
            wszyscyZawodnicyLista.Add(zawodnik);
            wszyscyZawodnicy = wszyscyZawodnicyLista.ToArray();

            if (zawodnik.Kraj.ToLower() == kraj.ToLower())
            {
                List<Zawodnik> wczytaniZawodnicyLista = wczytaniZawodnicy.ToList();
                wczytaniZawodnicyLista.Add(zawodnik);
                wczytaniZawodnicy = wczytaniZawodnicyLista.ToArray();
            }
        }

        internal void Sortuj(Sortowanie s)
        {
            kierunekSortowania = s;
            Array.Sort(wczytaniZawodnicy);
            Array.Sort(wszyscyZawodnicy);
        }

        public void Edytuj(Zawodnik z)
        {
            for (int i = 0; i < wczytaniZawodnicy.Length; i++)
                if (z.Id_zawodnika == wczytaniZawodnicy[i].Id_zawodnika)
                    wczytaniZawodnicy[i] = z;

            for (int i = 0; i < wszyscyZawodnicy.Length; i++)
                if (z.Id_zawodnika == wszyscyZawodnicy[i].Id_zawodnika)
                    wszyscyZawodnicy[i] = z;
        }

        internal void Usun(Zawodnik zawodnik)
        {
            List<Zawodnik> wszyscyZawodniyLista = wszyscyZawodnicy.ToList();
            wszyscyZawodniyLista.Remove(zawodnik);
            wszyscyZawodnicy = wszyscyZawodniyLista.ToArray();

            if (zawodnik.Kraj.ToLower() == kraj.ToLower())
            {
                List<Zawodnik> wczytaniZawodnicyLista = wczytaniZawodnicy.ToList();
                wczytaniZawodnicyLista.Remove(zawodnik);
                wczytaniZawodnicy = wczytaniZawodnicyLista.ToArray();
            }
        }

        public void Zapisz()
        {
            string plik = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga" + Environment.NewLine;
            foreach (var z in wszyscyZawodnicy)
            {
                plik += z.Wiersz + Environment.NewLine;
            }

            File.WriteAllText(sciezka, plik);
        }
    }
}