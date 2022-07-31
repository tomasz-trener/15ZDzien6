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
        private Zawodnik zawodnik;

        private enum TrybOkienka
        {
            Edycja,
            Nowy,
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy, Zawodnik zawodnik) : this(frmZawodnicy)
        {
            this.zawodnik = zawodnik;
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUr = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWaga.Value);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(zawodnik);
        }

        private void uzupelnijPola()
        {
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
        }
    }
}