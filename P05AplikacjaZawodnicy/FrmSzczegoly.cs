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

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy, Zawodnik zawodnik) : this(frmZawodnicy)
        {
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
        }

        private void uzupelnijPola()
        {
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
        }
    }
}