using Bunifu.Framework.UI;
using CrudAwal.Model.ModelBarangFarmasi;
using CrudAwal.Model.ModelGolonganObat;
using CrudAwal.Model.ModelJenisObat;
using CrudAwal.Model.ModelKelompokObat;
using CrudAwal.Model.ModelLogin;
using CrudAwal.Model.ModelPabrik;
using CrudAwal.Model.ModelRakbarang;
using CrudAwal.Model.ModelSatuan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal
{
    public partial class formMain : Form
    {
        public static string JUDUL_FORM = "";
        LoginData loginData = new LoginData();
        Login login = new Login();
        DataTable DLogin, DFarmasi, DRakbarang;
        BarangFarmasiData MBarangFarmasi = new BarangFarmasiData();
        KelompokObatData MKelompokObat = new KelompokObatData();
        JenisObatData MJenisObat = new JenisObatData();
        GolonganObatData MGolonganObat = new GolonganObatData();
        PabrikData MPabrik = new PabrikData();
        SatuanData MSatuan = new SatuanData();
        RakBarangData MRakBarang = new RakBarangData();
        BarangFarmasi BarangFarmasi = new BarangFarmasi();
        RakBarang RakBarang = new RakBarang();

        public formMain(string nama, string username)
        {
            InitializeComponent();
            tampilFoto(nama, username);
            lblJudulForm.Text = "Apotik Gudang";
        }

        void tampilFoto(string nama, string username)
        {
            login.Username = username;
            DLogin = loginData.getFoto(login);
            if (DLogin.Rows.Count > 0)
            {
                if (DLogin.Rows[0]["foto"] == null)
                {
                    lblUser.Text = nama;
                }
                else
                {
                    byte[] img = (byte[])DLogin.Rows[0]["foto"];
                    MemoryStream ms = new MemoryStream(img);
                    cpProfil.Image = Image.FromStream(ms);
                    lblUser.Text = nama;
                    DLogin.Dispose();
                }
            }
        }

        void tampilBarangFarmasi(BarangFarmasi request)
        {
            //MessageBox.Show(request);
            DataSet data = MBarangFarmasi.getBarangFarmasi(request);
            DFarmasi = data.Tables[0];
            DGMasterBarang.DataSource = DFarmasi;
            headerFarmasi();
        }

        void tampilRakBarang(RakBarang request)
        {
            MessageBox.Show(request.Cari);
            DataSet data = MRakBarang.getRakBarangAll(request);
            DRakbarang = data.Tables[0];
            DGMasterGudang.DataSource = DRakbarang;
            //headerFarmasi();
        }

        void headerFarmasi()
        {
            DGMasterBarang.Columns["kd_barang"].HeaderText = "KD Barang";
            DGMasterBarang.Columns["kd_barang"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["nama_barang"].HeaderText = "Nama Barang";
            DGMasterBarang.Columns["nama_barang"].Width = 200;
            DGMasterBarang.Columns["nama_barang"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGMasterBarang.Columns["kd_satuan_besar"].HeaderText = "Sat besar";
            DGMasterBarang.Columns["kd_satuan_besar"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["harga_satuan_besar"].HeaderText = "Harga besar";
            DGMasterBarang.Columns["harga_satuan_besar"].DefaultCellStyle.Format = "N2";
            DGMasterBarang.Columns["harga_satuan_besar"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["hrgsatbesarppn"].HeaderText = "Harga besar PPN";
            DGMasterBarang.Columns["hrgsatbesarppn"].DefaultCellStyle.Format = "N2";
            DGMasterBarang.Columns["hrgsatbesarppn"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["isi_satuan_besar"].HeaderText = "Isi";
            DGMasterBarang.Columns["isi_satuan_besar"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGMasterBarang.Columns["kd_satuan_kecil"].HeaderText = "Sat kecil";
            DGMasterBarang.Columns["kd_satuan_kecil"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["harga_satuan_netto"].HeaderText = "Harga kecil";
            DGMasterBarang.Columns["harga_satuan_netto"].DefaultCellStyle.Format = "N2";
            DGMasterBarang.Columns["harga_satuan_netto"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["harga_satuan"].Visible = false;

            DGMasterBarang.Columns["senpotbeli"].HeaderText = "Potongan";
            DGMasterBarang.Columns["senpotbeli"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["harga_jual"].HeaderText = "Harga Jual";
            DGMasterBarang.Columns["harga_jual"].DefaultCellStyle.Format = "N2";
            DGMasterBarang.Columns["harga_jual"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGMasterBarang.Columns["keterangan"].HeaderText = "Keterangan";
            DGMasterBarang.Columns["keterangan"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterBarang.Columns["stsaktif"].HeaderText = "Status";
            DGMasterBarang.Columns["stsaktif"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

        }

        void loadAwal()
        {
            pnlMaster.Visible = false;
            pnlPesan.Visible = false;
            pnlFaktur.Visible = false;
            pnlMutasi.Visible = false;
            pnlStok.Visible = false;
            pnlSetting.Visible = false;
            pnlFormBarang.Visible = false;
            pnlFormEntriBarang.Visible = false;
        }

        void pindahPanel(Panel panel, BunifuCards cardContent, Boolean nilai = false, String judul = "Apotik Gudang")
        {
            loadAwal();
            panel.Visible = nilai;
            lblJudulForm.Text = judul;
            foreach (Control c in cardContent.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnMaster.Height;
            pnlOnButtonPosition.Top = btnMaster.Top;
            pindahPanel(pnlMaster,bfCardFormBarang, true, "Menu Master");
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnPesan.Height;
            pnlOnButtonPosition.Top = btnPesan.Top;
            pindahPanel(pnlPesan, bfCardFormBarang, true, "Menu Pesan");
        }

        private void btnFaktur_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnFaktur.Height;
            pnlOnButtonPosition.Top = btnFaktur.Top;
            pindahPanel(pnlFaktur, bfCardFormBarang, true, "Menu Faktur");
        }

        private void btnMutasi_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnMutasi.Height;
            pnlOnButtonPosition.Top = btnMutasi.Top;
            pindahPanel(pnlMutasi, bfCardFormBarang, true, "Menu Mutasi");
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnStok.Height;
            pnlOnButtonPosition.Top = btnStok.Top;
            pindahPanel(pnlStok, bfCardFormBarang, true, "Menu Stok");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnSetting.Height;
            pnlOnButtonPosition.Top = btnSetting.Top;
            pindahPanel(pnlSetting, bfCardFormBarang, true, "Menu Setting");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            BarangFarmasi.Cari = txtCariBarang.Text;
            tampilBarangFarmasi(BarangFarmasi);
        }

        private void cmbStatusBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusBarang.Text == "Aktif")
            {
                BarangFarmasi.Stsaktif = "1";
            } else
            {
                BarangFarmasi.Stsaktif = "2";
            }
            //MessageBox.Show(BarangFarmasi.Cari); 
            tampilBarangFarmasi(BarangFarmasi);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            cmbStatusBarang.Text = "Aktif";
        }

        private void DGMasterBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pesan;
           if ( e.ColumnIndex == 0 )
            {
                pesan = DGMasterBarang.Rows[e.RowIndex].Cells["kd_barang"].Value.ToString();
                MessageBox.Show(pesan);
            }
        }
      
        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnMaster.Height;
            pnlOnButtonPosition.Top = btnMaster.Top;
            pindahPanel(pnlFormEntriBarang, bfCardEntriBarang, true);
            lblJudulForm.Text = "Entry Barang Farmasi";
            MKelompokObat.getdataKelompok(cmbKelompokBarang);
            MJenisObat.getJeniObat(cmbJenisBarang);
            MGolonganObat.getGolonganObat(cmbGolonganObat);
            MPabrik.getPabrik(cmbPabrikBarang);
            MSatuan.getSatuan(cmbSatuanBesar);
            MSatuan.getSatuan(cmbSatuanKecil);
            MRakBarang.getRakbarang(cmbRakBarang);
        }

        private void btnMasterUnit_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Unit Bagian";
            var formUnit = new ViewForm.FormUnit.formUnitBagian(JUDUL_FORM);
            formUnit.ShowDialog();
        }

        private void btnMasterSuplier_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Suplier";
            var formSuplier = new ViewForm.FormSuplier.formSuplier(JUDUL_FORM);
            formSuplier.ShowDialog();
        }

        private void btnMasterSatuan_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Satuan";
            var formSatuan = new ViewForm.FormSatuan.formSatuan(JUDUL_FORM);
            formSatuan.ShowDialog();
        }

        private void btnMasterPabrik_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Pakbrik";
            var formPabrik = new ViewForm.FormPabrik.formPabrik(JUDUL_FORM);
            formPabrik.ShowDialog();
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Pesanan";
            var formPesanan = new ViewForm.FormPesanan.formPesanan(JUDUL_FORM);
            formPesanan.ShowDialog();
        }
      
        private void btnMasterGudang_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Rak Barang";
            var formGudang = new ViewForm.FormGudang.formGudang(JUDUL_FORM);
            formGudang.ShowDialog();
        }

        private void btnMasterBarang_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "Data Barang Farmasi";
            var formBarang = new ViewForm.FormBarang.formBarang(JUDUL_FORM);
            formBarang.ShowDialog();
        }
    }
}
