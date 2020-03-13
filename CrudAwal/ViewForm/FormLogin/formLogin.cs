using CrudAwal.Model.ModelLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CrudAwal.ViewForm.FormLogin
{
    public partial class formLogin : Form
    {
        private string nama_kasir;
        LoginData loginData = new LoginData();
        Login login = new Login();
        DataTable DLogin;

        public formLogin()
        {
            InitializeComponent();
        }
        
        void tabulasi(KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
                txtPassword.Focus();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            tabulasi(e);
        }
        
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            login.Username = txtUsername.Text;
            DLogin = loginData.getFoto(login);
            if (DLogin.Rows.Count > 0)
            {
                if (DLogin.Rows[0]["foto"] == null)
                {
                    MLnama.Text = DLogin.Rows[0]["nama_pegawai"].ToString();
                    MLnip.Text = DLogin.Rows[0]["nip"].ToString();
                }
                else
                {
                    byte[] img = (byte[])DLogin.Rows[0]["foto"];
                    MemoryStream ms = new MemoryStream(img);
                    circlePicture1.Image = Image.FromStream(ms);
                    MLnama.Text = DLogin.Rows[0]["nama_pegawai"].ToString();
                    MLnip.Text = DLogin.Rows[0]["nip"].ToString();
                    DLogin.Dispose();
                }
            } 
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            login.Username = txtUsername.Text;
            login.Password = txtPassword.Text;
            if (login.Username == "")
            {
                MessageBox.Show("Username belum di isi!!", "peringatan", MessageBoxButtons.OK);
            } else if(login.Password == "")
            {
                MessageBox.Show("Password belum di isi!!", "peringatan", MessageBoxButtons.OK);
            } else
            {
                DLogin = loginData.loginUser(login);
                string pesan = string.Empty;

                if (DLogin.Rows.Count > 0)
                {
                    nama_kasir = DLogin.Rows[0]["nmkasir"].ToString();
                    pesan += "Selamat datang di Aplikasi Inventori! \n";
                    pesan += "Regard IT RSUD KRATON \n";
                    pesan += "Terimakasih!";
                    this.Hide();
                    formMain f = new formMain(nama_kasir,login.Username);
                    f.Show();
                }
                else
                {
                    pesan += "Akun tidak di temukan!! \n";
                    pesan += "Silahkan cek kembali!!! \n";
                    pesan += "Terimakasih!";
                }

                MessageBox.Show(pesan, "Konfirmasi!!!", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMsk_Click(object sender, EventArgs e)
        {
            login.Username = txtUsername.Text;
            login.Password = txtPassword.Text;
            if (login.Username == "")
            {
                MessageBox.Show("Username belum di isi!!", "peringatan", MessageBoxButtons.OK);
            }
            else if (login.Password == "")
            {
                MessageBox.Show("Password belum di isi!!", "peringatan", MessageBoxButtons.OK);
            }
            else
            {
                DLogin = loginData.loginUser(login);
                string pesan = string.Empty;

                if (DLogin.Rows.Count > 0)
                {
                    nama_kasir = DLogin.Rows[0]["nmkasir"].ToString();
                    pesan += "Selamat datang di Aplikasi Inventori! \n";
                    pesan += "Regard IT RSUD KRATON \n";
                    pesan += "Terimakasih!";
                    this.Hide();
                    formMain f = new formMain(nama_kasir, login.Username);
                    f.Show();
                }
                else
                {
                    pesan += "Akun tidak di temukan!! \n";
                    pesan += "Silahkan cek kembali!!! \n";
                    pesan += "Terimakasih!";
                }

                MessageBox.Show(pesan, "Konfirmasi!!!", MessageBoxButtons.OK);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMsk.PerformClick();
            } else if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }
    }
}
