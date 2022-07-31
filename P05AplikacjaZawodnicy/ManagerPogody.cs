using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    internal enum Jednostka
    {
        Celcjusz,
        Kelvin,
        Fahrenheit
    }

    internal class ManagerPogody
    {
        //properties = Właściwosci  - cechy obiektu (bardziej rozbudowane o akcesory dostepu czyli get i set)
        //fields = pola - to samo co właściwosć czyli cechy obiektu
        //methods = Metody - umiejetnosci danej klasy  czyli co dana klasa potrafi zrobic
        //constructors = Konstruktory  - taka funkcja, ktora sie wywoluje podczas tworzenia obiektu czyli ona definiuje sposób tworzenia obuiektu

        private const string urlSzalbon = "https://www.google.com/search?q=pogoda+";
        private const char znakSzukany = '°';
        private const char znakKoncowy = '>';
        private Jednostka jednostka;

        public ManagerPogody(Jednostka jednostka)
        {
            this.jednostka = jednostka;
        }

        /// <summary>
        /// Pobiera temperature z serwisu GOOGLE
        /// </summary>
        /// <param name="nazwaMiasta">Nazwa miasta, dla którego chcesz znaleźć temperature</param>
        /// <returns>Zwraca wartośc temepratury w stopniach Celcjusza</returns>
        public double PodajTemperature(string nazwaMiasta)
        {
            string url = urlSzalbon + nazwaMiasta;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);

            //File.WriteAllText(@"c:\dane\15z\pogoda.html", dane);
            //File.WriteAllText("c:\\dane\\15z\\pogoda.html", dane);
            // char p = dane[0];// mozemy odwolac sie do konkretnego znaku w stringu

            int indx = dane.IndexOf(znakSzukany);

            if (indx == -1)
                throw new Exception("Nie znaleziono znaku końcowego " + znakKoncowy);

            int aktualnaPozycja = indx;
            while (dane[aktualnaPozycja] != znakKoncowy)
                aktualnaPozycja--;

            // w tym momencie wiemy, ze aktualna pozycja
            // wskazuje na miejsce znaku koncowe <
            int dlugosc = indx - aktualnaPozycja;
            string wynik = dane.Substring(aktualnaPozycja + 1, dlugosc + 1 - 2);

            return transformuj(Convert.ToInt32(wynik));
        }

        private double transformuj(int temp)
        {
            if (jednostka == Jednostka.Celcjusz)
                return temp;

            if (jednostka == Jednostka.Fahrenheit)
                return (temp * 1.8) + 23;

            if (jednostka == Jednostka.Kelvin)
                return temp + 273.15;

            throw new Exception("Nieznana jednostka");
        }
    }
}