using CrudAwal.Model.ModelJenisObat;
using CrudAwal.Model.ModelPesanan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.IO;

namespace CrudAwal.ViewForm.FormPesanan
{
    public partial class formPesanan : Form
    {
        public static string JUDUL_FORM = "";
        Pesanan pesanan = new Pesanan();
        PesananData MPesanan = new PesananData();
        DataTable DPesanan;
        JenisObatData MJenisObat = new JenisObatData();
        ExcelEngine excelEngine = new ExcelEngine();
        DateTime now = DateTime.Now;
        
        private void awalLoad()
        {
            dtTanggalAwal.Value = now;
            dtTanggalAkhir.Value = now;
        }

        public formPesanan(String judul)
        {
            InitializeComponent();
            lblJudulForm.Text = judul;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formPesanan_Load(object sender, EventArgs e)
        {
            awalLoad();
            pesanan.Cari = txtCariPesanan.Text;
            tampilPesanan(pesanan);
            MJenisObat.getJeniObat(cmbJenisObat);
        }

        void tampilPesanan(Pesanan request)
        {
            DataSet data = MPesanan.getPesanan(request);
            DPesanan = data.Tables[0];
            DGPesanan.DataSource = DPesanan;
            headerPesanan();
            totalHarga();
        }

        void totalHarga()
        {
            Decimal HitungTotal = 0;
            for(int i = 0; i < DGPesanan.Rows.Count; ++i)
            {
                HitungTotal += Convert.ToDecimal(DPesanan.Rows[i]["jmlharga"]);
            }
            txtTotalHarga.DecimalValue = HitungTotal;
            txtQty.DecimalValue = DGPesanan.Rows.Count;
            //MessageBox.Show(HitungTotal.ToString()); 
           
        }

        void headerPesanan()
        {
            DGPesanan.Columns["nmkasir"].HeaderText = "Petugas";
            DGPesanan.Columns["nmkasir"].Width = 50;
            DGPesanan.Columns["nmkasir"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["tanggal"].HeaderText = "Tanggal";
            DGPesanan.Columns["tanggal"].Width = 75;
            DGPesanan.Columns["tanggal"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["notasp"].HeaderText = "Nota SP";
            DGPesanan.Columns["notasp"].Width = 90;
            DGPesanan.Columns["notasp"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["jns_obat"].HeaderText = "Jns Barang";
            DGPesanan.Columns["jns_obat"].Width = 50;
            DGPesanan.Columns["jns_obat"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["nmsuplier"].HeaderText = "Suplier";
            DGPesanan.Columns["nmsuplier"].Width = 200;
            DGPesanan.Columns["nmsuplier"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["kd_barang"].HeaderText = "Kode Barang";
            DGPesanan.Columns["kd_barang"].Width = 75;
            DGPesanan.Columns["kd_barang"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["nama_barang"].HeaderText = "Nama Barang";
            DGPesanan.Columns["nama_barang"].Width = 200;
            DGPesanan.Columns["nama_barang"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["harga"].HeaderText = "Harga";
            DGPesanan.Columns["harga"].Width = 125;
            DGPesanan.Columns["harga"].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["harga"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["jml"].HeaderText = "Jml Pesan";
            DGPesanan.Columns["jml"].Width = 50;
            DGPesanan.Columns["jml"].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns["jml"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["jml"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["nmsatuan"].HeaderText = "Satuan";
            DGPesanan.Columns["nmsatuan"].Width = 50;
            DGPesanan.Columns["nmsatuan"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["jmlharga"].HeaderText = "Total Harga";
            DGPesanan.Columns["jmlharga"].Width = 125;
            DGPesanan.Columns["jmlharga"].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns["jmlharga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["jmlharga"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["ttlmasuk"].HeaderText = "Jml Masuk";
            DGPesanan.Columns["ttlmasuk"].Width = 50;
            DGPesanan.Columns["ttlmasuk"].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns["ttlmasuk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["ttlmasuk"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["ttlsisa"].HeaderText = "Jml Sisa";
            DGPesanan.Columns["ttlsisa"].Width = 50;
            DGPesanan.Columns["ttlsisa"].DefaultCellStyle.Format = "N2";
            DGPesanan.Columns["ttlsisa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["ttlsisa"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            DGPesanan.Columns["stspesan"].HeaderText = "Status";
            DGPesanan.Columns["stspesan"].Width = 50;
            DGPesanan.Columns["stspesan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGPesanan.Columns["stspesan"].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            //for (int i = 1; i <= DGPesanan.Columns.Count -1; i++)
            //{
            //    DGPesanan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    int colw = DGPesanan.Columns[i].Width;
            //    DGPesanan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    DGPesanan.Columns[i].Width = colw;
            //}
        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            pesanan.Tanggal_awal = dtTanggalAwal.Value.ToString("yyyy-MM-dd");
            tampilPesanan(pesanan);
        }

        private void dtTanggalAkhir_ValueChanged(object sender, EventArgs e)
        {
            pesanan.Tanggal_akhir = dtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            tampilPesanan(pesanan);
        }

        private void txtCariPesanan_TextChanged(object sender, EventArgs e)
        {
            pesanan.Cari = txtCariPesanan.Text;
            tampilPesanan(pesanan);
        }

        private void cmbJenisObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pilih = this.cmbJenisObat.SelectedIndex;
            var jenisObat = this.cmbJenisObat.GetItemText(this.cmbJenisObat.SelectedItem);
            if (pilih == 0)
            {
                jenisObat = this.cmbJenisObat.GetItemText("");
            }
            pesanan.Jenis_obat = jenisObat;
            tampilPesanan(pesanan);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (txtQty.DecimalValue == 0)
            {
                MessageBox.Show("Data Belum ada, silahkan sesuai kan tanggal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Apakah akan di export ke Excel?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2013;
                       
                        // menambahkan colom noUrut
                        DPesanan.Columns.Add("noUrut", typeof(int));
                        DPesanan.Columns["noUrut"].AutoIncrement = true;
                        DPesanan.Columns["noUrut"].AutoIncrementSeed = 1;
                        DPesanan.Columns["noUrut"].AutoIncrementStep = 1;

                        // menambahkan nomer urut
                        for (int i = 0; i < DPesanan.Rows.Count; i++)
                        {
                            DPesanan.Rows[i]["noUrut"] = i+1;
                        }

                        // open marker template excel
                        IWorkbook workbook = application.Workbooks.Open(Application.StartupPath + "/Report/LaporanSuratPesananXLSIO.xlsx");
                        IWorksheet worksheet = workbook.Worksheets[0];
                        worksheet.Range["A7"].Text = "TANGGAL :    " + dtTanggalAwal.Value.ToString("dd-MMMM-yyyy") + " sampai " + dtTanggalAkhir.Value.ToString("dd-MMMM-yyyy");

                        //Membuat template maker proses
                        ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

                        marker.AddVariable("Data", DPesanan);
                        // aplikasi marker
                        marker.ApplyMarkers();
                        // defaul verision excel
                        workbook.Version = ExcelVersion.Excel2007;
                        // save dengan nama default
                        workbook.SaveAs("LaporanSuratPesanan_.xlsx");
                        workbook.Close();
                        excelEngine.Dispose();
                        // open file setelah di save
                        System.Diagnostics.Process.Start("LaporanSuratPesanan_.xlsx");
                    } catch (Exception error)
                    {
                        if (error is IOException)
                        {
                            MessageBox.Show("File sama sudah di buka!!!, silahkan simpan dengan nama file lain!!!", "Error!!", MessageBoxButtons.OK);
                        } else if (error is FormatException)
                        {
                            MessageBox.Show("Format file tidak sesuai yang di export!!!!", "Error!!!", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnTambahPesanan_Click(object sender, EventArgs e)
        {
            JUDUL_FORM = "ENTRY PESANAN BARANG";
            var formEntryPesanan = new formEntryPesanan(JUDUL_FORM);
            formEntryPesanan.ShowDialog();
        }
    }
}
