using CrudAwal.Model.ModelJenisObat;
using CrudAwal.Model.ModelSuplier;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormGlobal
{
    public partial class formListGlobal : Form
    {
        protected String FORM_PEMANGGIL;
        JenisObat jenisObat = new JenisObat();
        Suplier Suplier = new Suplier();
        JenisObatData MJenisObat = new JenisObatData();
        SuplierData MSuplier = new SuplierData();
        DataTable DBList;

        public formListGlobal(String judul, String formPemanggil)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
            FORM_PEMANGGIL = formPemanggil;
        }

        private void formListGlobal_Load(object sender, EventArgs e)
        {
            cekLoadData();
            txtCari.Focus();
            txtCari.Clear();
        }

        private void cekLoadData()
        {
            if (FORM_PEMANGGIL == "listObat")
            {
                jenisObat.Cari = txtCari.Text;
                listObat(jenisObat);
            } else if (FORM_PEMANGGIL == "listSuplier")
            {
                Suplier.Cari = txtCari.Text;
                listSuplier(Suplier);
            }
        }

        private void listSuplier(Suplier request)
        {
            DataSet data = MSuplier.getListSuplier(request);
            DBList = data.Tables[0];
            DGList.DataSource = DBList;
            headerList();
        }

        private void listObat(JenisObat request)
        {
            DataSet data = MJenisObat.getListObat(request);
            DBList = data.Tables[0];
            DGList.DataSource = DBList;
            headerList();
        }

        private void headerList()
        {
            DGList.Columns[0].Width = 40;
            DGList.Columns[1].HeaderText = "Kode";
            DGList.Columns[1].Width = 50;
            DGList.Columns[2].HeaderText = "Nama";
            DGList.Columns[2].Width = 250;
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

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {
                DGList.Focus();
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            cekLoadData();
        }

        private void DGList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (DBList.Rows[0][1] != System.DBNull.Value)
                {
                    if (FORM_PEMANGGIL == "listObat")
                    {
                        FormPesanan.formEntryPesanan.KD_JENIS = DGList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_JENIS = DGList.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                    else if (FORM_PEMANGGIL == "listSuplier")
                    {
                        FormPesanan.formEntryPesanan.KD_SUPLIER = DGList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_SUPLIER = DGList.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                    if (FORM_PEMANGGIL == "listObat")
                    {
                        FormPesanan.formEntryPesanan.KD_JENIS = DGList.Rows[i].Cells[1].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_JENIS = DGList.Rows[i].Cells[2].Value.ToString();
                    }
                    else if (FORM_PEMANGGIL == "listSuplier")
                    {
                        FormPesanan.formEntryPesanan.KD_SUPLIER = DGList.Rows[i].Cells[1].Value.ToString();
                        FormPesanan.formEntryPesanan.TXT_SUPLIER = DGList.Rows[i].Cells[2].Value.ToString();
                    }
                }
                this.Close();
            }
        }
    }
}
