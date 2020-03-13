using CrudAwal.Model.ModelSuplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormSuplier
{
    public partial class formSuplier : Form
    {
        Suplier Suplier = new Suplier();
        SuplierData MSuplier = new SuplierData();
        DataTable DSuplier;

        public formSuplier(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void tampilSuplier(Suplier request)
        {
            DataSet data = MSuplier.getSuplier(request);
            DSuplier = data.Tables[0];
            DGMasterSuplier.DataSource = DSuplier;
            headerSuplier();
        }

        void headerSuplier()
        {
            DGMasterSuplier.Columns["kdsuplier"].HeaderText = "Kode Suplier";
            DGMasterSuplier.Columns["kdsuplier"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterSuplier.Columns["nmsuplier"].HeaderText = "Nama Suplier";
            DGMasterSuplier.Columns["nmsuplier"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterSuplier.Columns["alamat"].HeaderText = "Alamat";
            DGMasterSuplier.Columns["alamat"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterSuplier.Columns["telpon"].HeaderText = "No Telpon";
            DGMasterSuplier.Columns["telpon"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            for (int i = 2; i <= DGMasterSuplier.Columns.Count -1; i++)
            {
                DGMasterSuplier.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGMasterSuplier.Columns[i].Width;
                DGMasterSuplier.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGMasterSuplier.Columns[i].Width = colw;
            }
        }

        private void formSuplier_Load(object sender, EventArgs e)
        {
            Suplier.Cari = txtCariSuplier.Text;
            tampilSuplier(Suplier);
        }

        private void txtCariSuplier_TextChanged(object sender, EventArgs e)
        {
            Suplier.Cari = txtCariSuplier.Text;
            tampilSuplier(Suplier);
        }
    }
}
