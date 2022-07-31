using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        private enum TrybOkienka
        {
            Edycja,
            Nowy,
        }

        private Zawodnik zawodnik;
        private ManagerZawodnikow mz;
        private FrmZawodnicy frmZawodnicy;
        private TrybOkienka trybOkienka => zawodnik == null ? TrybOkienka.Nowy : TrybOkienka.Edycja;

        public FrmSzczegoly(ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            this.mz = mz;
            this.frmZawodnicy = frmZawodnicy;
        }

        public FrmSzczegoly(ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy, Zawodnik zawodnik) : this(mz, frmZawodnicy)

        {
            this.zawodnik = zawodnik;
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
            btnUsun.Visible = true;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (trybOkienka == TrybOkienka.Edycja)
            {
                uzupelnijPola();

                mz.Edytuj(zawodnik);
            }
            else if (trybOkienka == TrybOkienka.Nowy)
            {
                zawodnik = new Zawodnik();
                uzupelnijPola();
                mz.StworzNowego(zawodnik);
            }
            else
                throw new Exception("Nieznany tryb okienka");

            mz.Zapisz();

            frmZawodnicy.Odswiez(mz.WczytaniZawodnicy);
        }

        private void uzupelnijPola()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUr = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr =
                MessageBox.Show("Czy napewno chcesz usunać zawodnika?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                mz.Usun(zawodnik);
                mz.Zapisz();
                frmZawodnicy.Odswiez(mz.WczytaniZawodnicy);
                Close();
            }
        }
    }
}