using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classmeet
{
    public partial class MenuUtama : Form
    {

        public MenuUtama()
        {
            InitializeComponent();
        }

        private void PaketLaundry_Click(object sender, EventArgs e)
        {
            PaketLaundry PL = new PaketLaundry();
            PL.Show();
            Hide();
        }

        private void DetailTransaksi_Click(object sender, EventArgs e)
        {
            DetailTransaksi DT = new DetailTransaksi();
            DT.Show();
            Hide();
        }

        private void DataKasir_Click(object sender, EventArgs e)
        {
            DataKasir DK = new DataKasir();
            DK.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormLogin FL = new FormLogin();
            FL.Show();
            Hide();
        }
    }
}
