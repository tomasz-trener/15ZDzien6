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
    public partial class NullableDateTimePicker : UserControl
    {
        public DateTime? Value
        {
            get
            {
                if (dtpData.Visible)
                    return dtpData.Value;

                return null;
            }
            set
            {
                if (value == null)
                    UkyjDate();
                else
                    PokazDate((DateTime)value);
            }
        }

        public NullableDateTimePicker()
        {
            InitializeComponent();

            int liczba = 4; //int jest not nullable
            int? liczbaZMozliwosciaPustej = 5;
            liczbaZMozliwosciaPustej = null;

            // liczba = null;
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            PokazDate(DateTime.Now);
        }

        private void PokazDate(DateTime dateTime)
        {
            txtData.Visible = false;
            dtpData.Visible = true;
            dtpData.Value = dateTime;
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                UkyjDate();
            }
        }

        private void UkyjDate()
        {
            txtData.Visible = true;
            dtpData.Visible = false;
        }
    }
}