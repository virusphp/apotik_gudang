using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CrudAwal
{
    // Form 1 Extend Form
    public partial class formPegawai : Form
    {
        public formPegawai(string role)
        {
            InitializeComponent();
            lblUser.Text = role;
        }

   
        PegawaiData MPegawai = new PegawaiData();
        FarmasiData MFarmasi = new FarmasiData();
        DataTable DPegawai, DFarmasi;

        void lihatDataPegawai()
        {
            DataSet data = MPegawai.getData();
            DPegawai = data.Tables[0];
            DGPegawai.DataSource = DPegawai;
            headerPegawai();
        }

        void lihatDataFarmasi()
        {
            DataSet data = MFarmasi.getData();
            DFarmasi = data.Tables[0];
            DGFarmasi.DataSource = DFarmasi;
            headerFarmasi();
        }

        void headerPegawai()
        {
            DGPegawai.Columns["nip"].HeaderText = "Nip";
            DGPegawai.Columns["nip"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            //dGridPegawai.Columns["nip"].DisplayIndex = 1; // mengganti index header
            DGPegawai.Columns["kd_pegawai"].HeaderText = "Kd Pegawai";
            DGPegawai.Columns["kd_pegawai"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGPegawai.Columns["nama_pegawai"].HeaderText = "Nama Pegawai";
            DGPegawai.Columns["nama_pegawai"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        void headerFarmasi()
        {
            DGFarmasi.Columns["uid"].HeaderText = "Username";
            DGFarmasi.Columns["uid"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGFarmasi.Columns["kdkasir"].HeaderText = "Kd Kasir";
            DGFarmasi.Columns["kdkasir"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGFarmasi.Columns["nmkasir"].HeaderText = "Nama Kasir";
            DGFarmasi.Columns["nmkasir"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGFarmasi.Columns["hak_akses"].HeaderText = "Role";
            DGFarmasi.Columns["hak_akses"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            lihatDataPegawai();
            lihatDataFarmasi();
            getPegawai();
            clearForm();
        }
                     
        private void button3_Click(object sender, EventArgs e)
        {
            //Pegawai pg = new Pegawai();
            //pg.Nip = txtNIP.Text;
            //pg.Nama = txtNAMA.Text;
            //pg.Jabatan = txtJABATAN.Text;
            //pg.Gaji = txtGAJI.Text;
            //pgd.updateData(pg, nip);
            //MessageBox.Show("BERHASIL DI UPDATE");
            //lihatData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtUID.Text = "";
            txtNAMA.Text = "";
            txtKDKASIR.Text = "";
            txtPASS.Text = "";
            MessageBox.Show("BERHASIL DI BATALKAN");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //MPegawai.deleteData();
            //MessageBox.Show("BERHASIL DI DiHAPUS");
            //lihatDataPegawai();
        }

        private void btnSimpan(object sender, EventArgs e)
        {
            passFarmasi pas = new passFarmasi();
            pas.Uid = txtUID.Text;
            pas.Nmkasir = txtNAMA.Text;
            pas.Kdkasir = txtKDKASIR.Text;
            pas.Pasword = txtPASS.Text;
            pas.Hak_akses = txtHAKAKSES.Text;
            MFarmasi.insertData(pas);
            MessageBox.Show("BERHASIL DI SIMPAN");
            lihatDataPegawai();
            clearForm();
        }

        void clearForm()
        {
            txtUID.Text = "";
            txtNAMA.Text = "";
            txtUID.ReadOnly = true;
            txtNAMA.ReadOnly = true;
            txtKDKASIR.Text = "";
            txtPASS.Text = "";
            txtHAKAKSES.Text = "";
        }

        private void dGridPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Apa anda yakin ??", "Konfirmasi", MessageBoxButtons.YesNo);
            if(konfirmasi == DialogResult.Yes)
            {
                txtUID.Text = DGPegawai.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNAMA.Text = DGPegawai.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                txtUID.Text = "";
                txtNAMA.Text = "";
                lihatDataPegawai();
            }
        }

        private void txtCARI_KeyPress(object sender, KeyPressEventArgs e)
        {
            cariPegawai(txtCARIPEGAWAI.Text);
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            cariPegawai(txtCARIPEGAWAI.Text);
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            cariPegawai(txtCARIPEGAWAI.Text);
        }

        private void txtKDKASIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || txtKDKASIR.Text.Length  >= 3)
            {
                validasiFarmasi(txtKDKASIR.Text);
            }
        }

        private void txtCARIFARMASI_TextChanged(object sender, EventArgs e)
        {
            cariUserFarmasi(txtCARIFARMASI.Text);
        }

        private void txtCARIFARMASI_KeyPress(object sender, KeyPressEventArgs e)
        {
            cariUserFarmasi(txtCARIFARMASI.Text);
        }

        void cariUserFarmasi(String term)
        {
            passFarmasi pf = new passFarmasi();
            DFarmasi = MFarmasi.cariData(term);
            DGFarmasi.DataSource = DFarmasi;
        }

        void validasiFarmasi(String term)
        {
            passFarmasi pf = new passFarmasi();
            DataTable DTkasir = new DataTable();
            DTkasir = MFarmasi.getUser(term);
            string pesan = string.Empty;
            if (DTkasir != null)
            {
                if (DTkasir.Rows.Count > 0)
                {
                    object b = DTkasir.Rows[0]["kdkasir"];
                    string kdkasir = string.Empty;
                    kdkasir = Convert.ToString(b);

                    if (txtKDKASIR.Text == kdkasir)
                    {
                        pesan += "Kode user sudah di pakai oleh " + kdkasir + "\n";
                        pesan += "Silahkan pakai kode yang lain \n";
                        pesan += "Terimaksih";
                        txtKDKASIR.Text = "";
                    }
                }
                else
                {
                    pesan += "Kode boleh di pakai";
                }
                
            }
            else
            {
                pesan += "Kode boleh di pakai";
            }

            MessageBox.Show(pesan, "Peringatan!!!", MessageBoxButtons.OK);
            
        }

        void cariPegawai(String term)
        {
            Pegawai pg = new Pegawai();
            DPegawai = MPegawai.cariData(term);
            DGPegawai.DataSource = DPegawai;
        }

        private void formPegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DGPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void getPegawai()
        {
            if (txtCARIPEGAWAI.Text == "" || txtCARIFARMASI.Text == "")
            {
                lihatDataPegawai();
                lihatDataFarmasi();
            }
        }
    }
}
