using System;
using System.IO;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {
        private ManagerZawodnikow mz;

        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez(Zawodnik[] zawodnicy)
        {
            lbDane.DisplayMember = "";
            // kiedy ponownie binduje dane, które mają taką samą strukturę to muszę wyzerować DisplayMember
            // jzeli tego nie zrobię to kontrolka myśli, że te dane w ogołe się nie zmieniły i
            // nie przeprowadza ponownego bindowania danych

            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";

            lblLicznaZaimportowanychDanych.Text = Convert.ToString(zawodnicy.Length);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dane = File.ReadAllLines(ofd.FileName);

                //lbDane.Items.Clear();
                //foreach (var w in dane)
                //    lbDane.Items.Add(w);

                mz = new ManagerZawodnikow(txtKraj.Text, ofd.FileName);
                Zawodnik[] zawodnicy = mz.Wczytaj(dane);

                Odswiez(zawodnicy);
            }
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczone = (Zawodnik)lbDane.SelectedItem;

            FrmSzczegoly fs = new FrmSzczegoly(mz, this, zaznaczone);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(mz, this);
            fs.Show();
        }

        private void rbKolumna_Click(object sender, EventArgs e)
        {
            Sortowanie s;
            if (rbImie.Checked)
                s = Sortowanie.Imie;
            else if (rbNazwisko.Checked)
                s = Sortowanie.Nazwisko;
            else if (rbWzrost.Checked)
                s = Sortowanie.Wzrost;
            else
                throw new Exception("Nieznany kierunek sortowania");

            mz.Sortuj(s);
            Odswiez(mz.WczytaniZawodnicy);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            mz.Zapisz();
        }
    }
}