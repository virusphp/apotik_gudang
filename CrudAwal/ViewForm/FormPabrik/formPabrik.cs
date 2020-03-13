using CrudAwal.Model.ModelPabrik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormPabrik
{
    public partial class formPabrik : Form
    {
        Pabrik pabrik = new Pabrik();
        PabrikData MPabrik = new PabrikData();
        DataTable DPabrik;

        public formPabrik(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formPabrik_Load(object sender, EventArgs e)
        {
            pabrik.Cari = txtCariPabrik.Text;
            tampilPabrik(pabrik);
        }

        void tampilPabrik(Pabrik request)
        {
            DataSet data = MPabrik.getAllPabrik(request);
            DPabrik = data.Tables[0];
            DGMasterPabrik.DataSource = DPabrik;
            headerPabrik();
        }

        void headerPabrik()
        {
            DGMasterPabrik.Columns["kdpabrik"].HeaderText = "Kode Pabrik";
            DGMasterPabrik.Columns["kdpabrik"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterPabrik.Columns["nmpabrik"].HeaderText = "Nama Pabrik";
            DGMasterPabrik.Columns["nmpabrik"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            for (int i = 2; i <= DGMasterPabrik.Columns.Count - 1; i++)
            {
                DGMasterPabrik.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGMasterPabrik.Columns[i].Width;
                DGMasterPabrik.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGMasterPabrik.Columns[i].Width = colw;
            }
        }

        private void txtCariPabrik_TextChanged(object sender, EventArgs e)
        {
            pabrik.Cari = txtCariPabrik.Text;
            tampilPabrik(pabrik);
        }
    }
}
