using CrudAwal.Model.ModelRakbarang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormGudang
{
    public partial class formGudang : Form
    {
        RakBarang RakBarang = new RakBarang();
        RakBarangData MRakBarang = new RakBarangData();
        DataTable DGudang;

        public formGudang(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        void tampiGUdang(RakBarang request)
        {
            DataSet data = MRakBarang.getRakBarangAll(request);
            DGudang = data.Tables[0];
            DGMasterGudang.DataSource = DGudang;
            headerFarmasi();
        }

        void headerFarmasi()
        {
            DGMasterGudang.Columns["noid"].HeaderText = "Nomor";
            DGMasterGudang.Columns["noid"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterGudang.Columns["nmrakbarang"].HeaderText = "Nama Gudang";
            DGMasterGudang.Columns["nmrakbarang"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void formGudang_Load(object sender, EventArgs e)
        {
            RakBarang.Cari = txtCariGudang.Text;
            tampiGUdang(RakBarang);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCariGudang_TextChanged(object sender, EventArgs e)
        {
            RakBarang.Cari = txtCariGudang.Text;
            tampiGUdang(RakBarang);
        }
    }
}
