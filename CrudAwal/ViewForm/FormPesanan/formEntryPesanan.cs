using CrudAwal.Model.ModelBarangFarmasi;
using CrudAwal.Model.ModelJenisObat;
using CrudAwal.Model.ModelPesanan;
using CrudAwal.ViewForm.FormGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.ViewForm.FormPesanan
{
    public partial class formEntryPesanan : Form
    {
        public static string JUDUL_FORM = "";
        public static string FORM_PEMANGGIL = "";
        public static string KD_JENIS, TXT_JENIS = "";
        public static string KD_SUPLIER, TXT_SUPLIER = "";
        public static string KD_BARANG, TXT_BARANG = "";
        private string satuan_besar, idx_barang;
        DateTime now = DateTime.Now;
        BarangFarmasi barang = new BarangFarmasi();
        BarangFarmasiData MBarang = new BarangFarmasiData();
        Pesanan pesanan = new Pesanan();
        JenisObat jenisObat = new JenisObat();
        PesananData MPesanan = new PesananData();
        DataTable DNotaSP, DBarang;
        DataTable DPesanan = new DataTable();
        DataRow dtRow;

        public formEntryPesanan(String judul)
        {
            InitializeComponent();
            lblJam.Text = now.ToShortDateString();
            lblJudulForm.Text = judul;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kosongkanDetail()
        {
            dtTanggalSP.Value = now;
            txtKodeBarang.Text = "Tekan Enter";
            txtKodeBarang.ForeColor = Color.Gray;
            txtNamaBarang.Clear();
            txtJumlahIsi.Clear();
            txtHargaNetKecil.Clear();
            txtDiskonKecil.Clear();
            txtHargaDiskonKecil.Clear();
            txtHargaPPNKecil.Clear();
            txtHargaNetBesar.Clear();
            txtDiskonBesar.Clear();
            txtHargaDiskonBesar.Clear();
            txtPPNKecil.Clear();
            txtPPNBesar.Clear();
            txtHargaPPNBesar.Clear();
            txtJumlahBesar.Clear();
            txtJumlahHargaBesar.Clear();
            lblSatuanBesar.Text = "";
            lblSatuanKecil.Text = "";
            txtKodeBarang.Focus();
        }

        private void nomorSP()
        {
            kosongkanDetail();
            pesanan.Tanggal_awal = dtTanggalSP.Value.ToString("MM");
            pesanan.Tanggal_akhir = dtTanggalSP.Value.ToString("yyyy");
            DataSet data = MPesanan.getNomorSP(pesanan);
            DNotaSP = data.Tables[0];
            var tglNomor = "/" + dtTanggalSP.Value.ToString("MM") + "/" + dtTanggalSP.Value.ToString("yy") + "/SP";
            //MessageBox.Show(data.Tables[0].Rows.Count);
            if (DNotaSP.Rows[0]["notasp"] == System.DBNull.Value)
            {
                txtNomorSP.Text = "001" + tglNomor;
            } else
            {
                string nomor = DNotaSP.Rows[0]["notasp"].ToString().Substring(0, 3);
                Decimal nomer = Convert.ToDecimal(nomor) + 1; 
                if (nomor.Length == 3) {
                    txtNomorSP.Text = "00" + nomer + tglNomor;
                } else if (nomor.Length == 2)
                {
                    txtNomorSP.Text = "0" + nomor + tglNomor;
                } else
                {
                    txtNomorSP.Text = "" + nomer + tglNomor;
                }
                MessageBox.Show(txtNomorSP.Text);
            }
        }

        private void setTabel()
        {
            // Datatable membuat Header
            DPesanan.Columns.Add("kdBarang");
            DPesanan.Columns.Add("nmBarang");
            DPesanan.Columns.Add("hargaPPNBesar", typeof(decimal));
            DPesanan.Columns.Add("jumlahBesar", typeof(decimal));
            DPesanan.Columns.Add("nmSatuan");
            DPesanan.Columns.Add("jumlahHarga", typeof(decimal));
            DPesanan.Columns.Add("idxBarang");

            DGPesanan.DataSource = DPesanan;
         
        }

        private void headerTabel()
        {
            DGPesanan.Columns[0].HeaderText = "Hapus";
            DGPesanan.Columns[0].ReadOnly = true;
            DGPesanan.Columns[0].Width = 50;
            DGPesanan.Columns[1].HeaderText = "Kode Barang";
            DGPesanan.Columns[1].ReadOnly = true;
            DGPesanan.Columns[1].Width = 100;
            DGPesanan.Columns[2].HeaderText = "Nama Barang";
            DGPesanan.Columns[2].ReadOnly = true;
            DGPesanan.Columns[2].Width = 220;
            DGPesanan.Columns[3].HeaderText = "Harga";
            DGPesanan.Columns[3].ReadOnly = true;
            DGPesanan.Columns[3].Width = 100;
            DGPesanan.Columns[3].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns[4].HeaderText = "Jumlah";
            DGPesanan.Columns[4].ReadOnly = true;
            DGPesanan.Columns[4].Width = 80;
            DGPesanan.Columns[4].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns[5].HeaderText = "Satuan";
            DGPesanan.Columns[5].Width = 100;
            DGPesanan.Columns[6].HeaderText = "Jumlah Harga";
            DGPesanan.Columns[6].ReadOnly = true;
            DGPesanan.Columns[6].Width = 120;
            DGPesanan.Columns[6].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns[6].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            DGPesanan.Columns[7].Visible = false;
            DGPesanan.Columns["idxBarang"].Visible = false;

            for (int i = 2; i <= DGPesanan.Columns.Count - 1; i++)
            {
                DGPesanan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = DGPesanan.Columns[i].Width;
                DGPesanan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGPesanan.Columns[i].Width = colw;
            }
        }

        private void addToTable()
        {
            // Datatable mengisi row atau data 
            DPesanan.Rows.Add(txtKodeBarang.Text, 
                txtNamaBarang.Text, 
                txtHargaPPNBesar.DecimalValue, 
                txtJumlahBesar.DecimalValue, 
                satuan_besar, 
                txtJumlahHargaBesar.DecimalValue, 
                idx_barang);

            DGPesanan.DataSource = DPesanan;
        }

        private void addPesanan()
        {
            dtRow = DPesanan.NewRow();
            dtRow["kdBarang"] = txtKodeBarang.Text;
            dtRow["nmBarang"] = txtNamaBarang.Text;
            dtRow["hargaPPNBesar"] = txtHargaPPNBesar.DecimalValue;
            dtRow["jumlahBesar"] = txtJumlahBesar.DecimalValue;
            dtRow["nmSatuan"] = satuan_besar;
            dtRow["jumlahHarga"] = txtJumlahHargaBesar.DecimalValue;
            dtRow["idxBarang"] = idx_barang;
            DPesanan.Rows.Add(dtRow);
            DGPesanan.DataSource = DPesanan;

            totalHarga();
        }

        void totalHarga()
        {
            Decimal HitungTotal = 0;
            for (int i = 0; i < DGPesanan.Rows.Count; ++i)
            {
                HitungTotal += Convert.ToDecimal(DPesanan.Rows[i]["jumlahHarga"]);
            }
            txtTotalHarga.DecimalValue = HitungTotal;
            txtQty.DecimalValue = DGPesanan.Rows.Count;
            //MessageBox.Show(HitungTotal.ToString()); 

        }

        private void hitung()
        {
            txtJumlahHargaBesar.DecimalValue = txtHargaPPNBesar.DecimalValue * txtJumlahBesar.DecimalValue;
        }

        private void dtTanggalSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.KeyChar = (Char)Keys.Tab;
                SendKeys.Send(e.KeyChar.ToString());
            }
        }

        private void txtSuplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtKodeBarang.Focus();
                JUDUL_FORM = "LIST Suplier";
                FORM_PEMANGGIL = "listSuplier";
                var FormList = new formListGlobal(JUDUL_FORM, FORM_PEMANGGIL);
                FormList.ShowDialog();
                txtSuplier.Text = TXT_SUPLIER;
            }
        }

        private void txtNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            } else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtHargaPPNBesar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtJumlahBesar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtJumlahHargaBesar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtNamaBarang_Leave(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text != "")
            {
                barang.Cari = txtKodeBarang.Text;
                DataSet data = MBarang.getBarangByKode(barang);
                DBarang = data.Tables[0];
                //MessageBox.Show(DBarang.Rows[0]["senpotbeli"].ToString());
                if (DBarang.Rows.Count > 0)
                {
                    lblSatuanBesar.Text = "Per " + DBarang.Rows[0]["kd_satuan_besar"].ToString();
                    satuan_besar = DBarang.Rows[0]["kd_satuan_besar"].ToString();
                    txtHargaNetBesar.DecimalValue = (Decimal)DBarang.Rows[0]["harga_satuan_besar"];
                    txtDiskonBesar.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["senpotbeli"].ToString());
                    txtHargaDiskonBesar.DecimalValue = (Decimal)DBarang.Rows[0]["hpp"];
                    txtPPNBesar.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["ppn1"].ToString());
                    txtHargaPPNBesar.DecimalValue = (Decimal)DBarang.Rows[0]["hrgsatbesarppn"];
                    txtJumlahIsi.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["isi_satuan_besar"].ToString());

                    lblSatuanKecil.Text = "Per " + DBarang.Rows[0]["kd_satuan_kecil"].ToString();
                    txtHargaNetKecil.DecimalValue = (Decimal)DBarang.Rows[0]["harga_satuan_netto"];
                    txtDiskonKecil.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["senpotbeli"].ToString());
                    txtHargaDiskonKecil.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["harga_jual"].ToString());
                    txtPPNKecil.DecimalValue = Convert.ToDecimal(DBarang.Rows[0]["ppn2"].ToString());
                    txtHargaPPNKecil.DecimalValue = (Decimal)DBarang.Rows[0]["harga_satuan"];
                    idx_barang = DBarang.Rows[0]["idx_barang"].ToString();
                } else
                {
                    MessageBox.Show("Data tidak di temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtJumlahBesar_TextChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            //validasi jika barang kosong dan isi kosong
            if (txtKodeBarang.Text == "Tekan Enter")
            {
                MessageBox.Show("Pilih barang terlebih dulu!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKodeBarang.Focus();
            }
            if (txtJumlahBesar.DecimalValue == 0)
            {
                MessageBox.Show("Jumlah barang di isi dulu!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahBesar.Focus();
            }

            if (btnSimpan.Text == "SIMPAN [F1]")
            {
                for (int i = 0; i < DGPesanan.RowCount ; i++)
                {
                    if (txtKodeBarang.Text.Trim() == DGPesanan.Rows[i].Cells["kdBarang"].Value.ToString())
                    {
                        MessageBox.Show("Barang ini : " + txtNamaBarang.Text + " sudah di entry", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kosongkanDetail();
                        txtKodeBarang.Focus();
                    }
                }

                hitung();
                addPesanan();
                pnlHeader.Enabled = false;
                kosongkanDetail();
            }

           
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtQty.DecimalValue == 0)
            {
                MessageBox.Show("Barang belum ada yang masuk!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtTanggalSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }

        private void DGPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Yakin akan di hapus?!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (DGPesanan.CurrentRow.Index != DGPesanan.NewRowIndex)
                    {
                        DGPesanan.Rows.RemoveAt(DGPesanan.CurrentRow.Index);
                    }
                    txtQty.DecimalValue = DGPesanan.Rows.Count;
                    totalHarga();
                }
            }
        }

        private void txtKodeBarang_LosFocus(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text == "Tekan Enter")
            {
                txtKodeBarang.ForeColor = Color.Gray;
            } else
            {
                txtKodeBarang.ForeColor = Color.Black;
            }
        }

        private void txtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtJenis.Text == "Tekan Enter")
                {
                    MessageBox.Show("Silahkan pilih jenis dulu", "Peringatan!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJenis.Focus();
                } else if(txtSuplier.Text == "Tekan Enter")
                {
                    MessageBox.Show("Silahkan pilih suplier dulu", "Peringatan!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSuplier.Focus();
                } else
                {
                    txtNamaBarang.Focus();
                    JUDUL_FORM = "LIST Barang";
                    FORM_PEMANGGIL = "listBarang";
                    var FormList = new formListBarang(JUDUL_FORM, FORM_PEMANGGIL);
                    FormList.ShowDialog();
                    txtKodeBarang.Text = KD_BARANG;
                    txtNamaBarang.Text = TXT_BARANG;
                }
            } else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtNomorSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtJenis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSuplier.Focus();
                JUDUL_FORM = "LIST OBAT";
                FORM_PEMANGGIL = "listObat";
                var FormList = new formListGlobal(JUDUL_FORM, FORM_PEMANGGIL);
                FormList.ShowDialog();
                txtJenis.Text = TXT_JENIS;
            }
        }

        private void formEntryPesanan_Load(object sender, EventArgs e)
        {
            kosongkanDetail();
            nomorSP();
            setTabel();
            headerTabel();
        }
    }
}
