using System;
using System.IO;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez(Zawodnik[] zawodnicy)
        {
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";
            lblLicznaZaimportowanychDanych.Text = zawodnicy.Length.ToString();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnik[] zawodnicy = zr.WczytajZawodnikow(txtFiltr.Text);
            Odswiez(zawodnicy);
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
        }

        private void rbKolumna_Click(object sender, EventArgs e)
        {
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
        }
    }
}