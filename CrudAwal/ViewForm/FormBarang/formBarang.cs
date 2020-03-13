using CrudAwal.Model.ModelBarangFarmasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormBarang
{
    public partial class formBarang : Form
    {
        BarangFarmasi BarangFarmasi = new BarangFarmasi();
        BarangFarmasiData MBarangFarmasi = new BarangFarmasiData();
        DataTable DFarmasi;

        public formBarang(String judul)
        {
           InitializeComponent();
           lblJudulForm.Text = judul;
        }
         
        void tampilBarangFarmasi(BarangFarmasi request)
        {
            DataSet data = MBarangFarmasi.getBarangFarmasi(request);
            DFarmasi = data.Tables[0];
            DGMasterBarang.DataSource = DFarmasi;
            headerFarmasi();
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

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formBarang_Load(object sender, EventArgs e)
        {
            cmbStatusBarang.Text = "Aktif";
            BarangFarmasi.Cari = txtCariBarang.Text;
            tampilBarangFarmasi(BarangFarmasi);
        }

        private void cmbStatusBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusBarang.Text == "Aktif")
            {
                BarangFarmasi.Stsaktif = "1";
            }
            else
            {
                BarangFarmasi.Stsaktif = "2";
            }
            //MessageBox.Show(BarangFarmasi.Cari); 
            tampilBarangFarmasi(BarangFarmasi);
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            BarangFarmasi.Cari = txtCariBarang.Text;
            tampilBarangFarmasi(BarangFarmasi);
        }
    }
}
