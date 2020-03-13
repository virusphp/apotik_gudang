using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.Model.ModelGolonganObat
{
    class GolonganObatData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public GolonganObatData()
        {
            koneksi = konek();
        }

        public DataTable getGolonganObat(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT RTRIM(LTRIM(kd_gol_obat)) AS kd_gol_obat, RTRIM(LTRIM(gol_obat)) AS gol_obat FROM golongan_obat WHERE stsaktif='1' ORDER BY kd_gol_obat";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<---- Pilih ----->" };
                dt.Rows.InsertAt(drw, 0);
                cmb.DataSource = dt;
                cmb.DisplayMember = "gol_obat";
                cmb.ValueMember = "kd_gol_obat";
                cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (SqlException)
            {

            }
            finally
            {
                koneksi.Close();
            }
            return dt;
        }
    }
}
