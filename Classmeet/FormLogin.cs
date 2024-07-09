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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextPass.Focus();
            }
        }

        private void TextPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformLogin();
            }
        }

        private void BtnKlik_Click_1(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            string username = TextUser.Text;
            string password = TextPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("UserName dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "Fulan" && password == "Fulan123")
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuUtama MU = new MenuUtama();
                MU.Show();
                Hide();
            }
            else if (username == "Kasir" && password == "Kasir123")
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuUtama MU1 = new MenuUtama();
                MU1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Password dan username salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextUser.Clear();
                TextPass.Clear();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
