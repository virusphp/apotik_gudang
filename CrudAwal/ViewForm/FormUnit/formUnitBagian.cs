using CrudAwal.Model.ModelUnitBagian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormUnit
{
    public partial class formUnitBagian : Form
    {
        UnitBagian Unit = new UnitBagian();
        UnitBagianData MUnit = new UnitBagianData();
        DataTable DUnit;

        public formUnitBagian(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        void tampilUnitBagian(UnitBagian request)
        {
            DataSet data = MUnit.getUnitBagian(request);
            DUnit = data.Tables[0];
            DGMasterUnit.DataSource = DUnit;
            headerUnitBagian();
        }

        void headerUnitBagian()
        {
            DGMasterUnit.Columns["kdbagian"].HeaderText = "Kode Unit";
            DGMasterUnit.Columns["kdbagian"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGMasterUnit.Columns["nmbagian"].HeaderText = "Nama Unit";
            DGMasterUnit.Columns["nmbagian"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            for (int i = 2; i <= DGMasterUnit.Columns.Count - 1; i++)
            {
                DGMasterUnit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGMasterUnit.Columns[i].Width;
                DGMasterUnit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGMasterUnit.Columns[i].Width = colw;
            }
        }

        private void formUnitBagian_Load(object sender, EventArgs e)
        {
            Unit.Cari = txtCariUnit.Text;
            tampilUnitBagian(Unit);
        }

        private void txtCariUnit_TextChanged(object sender, EventArgs e)
        {
            Unit.Cari = txtCariUnit.Text;
            tampilUnitBagian(Unit);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
