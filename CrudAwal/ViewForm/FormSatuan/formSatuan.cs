using CrudAwal.Model.ModelSatuan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormSatuan
{
    public partial class formSatuan : Form
    {
        Satuan Satuan = new Satuan();
        SatuanData MSatuan = new SatuanData();
        DataTable DSatuan;

        public formSatuan(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formSatuan_Load(object sender, EventArgs e)
        {
            Satuan.Cari = txtCariSatuan.Text;
            tampilSatuan(Satuan);
        }

        void tampilSatuan(Satuan request)
        {
            DataSet data = MSatuan.getAllSatuan(request);
            DSatuan = data.Tables[0];
            DGMasterSatuan.DataSource = DSatuan;
            headerSatuan();
        }

        void headerSatuan()
        {
            DGMasterSatuan.Columns["idsatuan"].HeaderText = "Kode Satuan";
            DGMasterSatuan.Columns["idsatuan"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterSatuan.Columns["nmsatuan"].HeaderText = "Nama Satuan";
            DGMasterSatuan.Columns["nmsatuan"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            for (int i = 2; i <= DGMasterSatuan.Columns.Count - 1; i++)
            {
                DGMasterSatuan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGMasterSatuan.Columns[i].Width;
                DGMasterSatuan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGMasterSatuan.Columns[i].Width = colw;
            }
        }

        private void txtCariSatuan_TextChanged(object sender, EventArgs e)
        {
            Satuan.Cari = txtCariSatuan.Text;
            tampilSatuan(Satuan);
        }
    }
}
