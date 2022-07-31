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

        public void Odswiez()
        {
            string sortowanie = null;
            if (rbImie.Checked)
                sortowanie = (string)rbImie.Tag;
            if (rbNazwisko.Checked)
                sortowanie = (string)rbNazwisko.Tag;
            if (rbWzrost.Checked)
                sortowanie = (string)rbWzrost.Tag;

            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.WczytajZawodnikow(txtFiltr.Text, sortowanie);
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";
            lblLicznaZaimportowanychDanych.Text = zawodnicy.Length.ToString();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this);
            fs.Show();
        }

        private void rbKolumna_Click(object sender, EventArgs e)
        {
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
        }
    }
}