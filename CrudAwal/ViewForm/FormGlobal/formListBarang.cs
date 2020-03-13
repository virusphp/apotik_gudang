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

namespace CrudAwal.ViewForm.FormGlobal
{
    public partial class formListBarang : Form
    {
        protected String FORM_PEMANGGIL;
        BarangFarmasi Barang = new BarangFarmasi();
        BarangFarmasiData MBarang = new BarangFarmasiData();
        DataTable DBList;

        public formListBarang(String judul, String formPemanggil)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
            FORM_PEMANGGIL = formPemanggil;
        }

        private void formListBarang_Load(object sender, EventArgs e)
        {
            loadData();
            txtCari.Focus();
            txtCari.Clear();
        }

        private void loadData()
        {
            if (FORM_PEMANGGIL == "listBarang")
            {
                Barang.Cari = txtCari.Text;
                listBarang(Barang);
            }
        }

        private void listBarang(BarangFarmasi request)
        {
            DataSet data = MBarang.getListBarang(request);
            DBList = data.Tables[0];
            DGList.DataSource = DBList;
            headerList();
        }

        private void headerList()
        {
            DGList.Columns[0].Width = 40;
            DGList.Columns[1].HeaderText = "IDX";
            DGList.Columns[1].Width = 50;
            DGList.Columns[2].HeaderText = "Kode Barang";
            DGList.Columns[2].Width = 50;
            DGList.Columns[3].HeaderText = "Nama Barang";
            DGList.Columns[3].Width = 200;
            DGList.Columns[4].HeaderText = "Harga Net Besar";
            DGList.Columns[4].Width = 50;
            DGList.Columns[5].HeaderText = "Harga Besar + PPN";
            DGList.Columns[5].Width = 50;

            DGList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            for (int i = 2; i <= DGList.Columns.Count - 1; i++)
            {
                DGList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGList.Columns[i].Width;
                DGList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGList.Columns[i].Width = colw;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void DGList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (DBList.Rows[0][1] != System.DBNull.Value)
                {
                    if (FORM_PEMANGGIL == "listBarang")
                    {
                        FormPesanan.formEntryPesanan.KD_BARANG = DGList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_BARANG = DGList.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                }
                this.Close();
            }
        }

        private void DGList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                var i = DGList.CurrentRow.Index - 1;
                if (DBList.Rows[i][1] != System.DBNull.Value)
                {
                    if (FORM_PEMANGGIL == "listBarang")
                    {
                        FormPesanan.formEntryPesanan.KD_BARANG = DGList.Rows[i].Cells[2].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_BARANG = DGList.Rows[i].Cells[3].Value.ToString();
                    }
                }
                this.Close();
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                DGList.Focus();
            }
        }
    }
}
