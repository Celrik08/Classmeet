using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classmeet
{
    public partial class PaketLaundry : Form
    {
        public PaketLaundry()
        {
            InitializeComponent();
        }
        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextHarga.Focus();
            }
        }

        private void TextHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextHarga.Focus();
            }
        }

        private void TextDeskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformLaundry();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerformLaundry();
        }

        private void PerformLaundry()
        {

            string nama = TextNama.Text;
            string harga = TextHarga.Text;
            string deskripsi = TextDeskripsi.Text;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(deskripsi))
            {
                MessageBox.Show("Komponen tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataLaundry.Rows.Add(nama, harga, deskripsi);
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {

        }

        private void DataLaundry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
