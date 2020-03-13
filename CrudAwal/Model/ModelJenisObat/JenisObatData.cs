using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.Model.ModelJenisObat
{
    class JenisObatData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public JenisObatData()
        {
            koneksi = konek();
        }

        public DataSet getListObat(JenisObat request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT  RTRIM(LTRIM(kd_jns_obat)) AS kd_jns_obat,LTRIM(RTRIM(jns_obat)) AS nama FROM jenis_obat WHERE stsaktif='1' AND jns_obat LIKE '%" +request.Cari+ "%' ORDER BY kd_jns_obat";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                koneksi.Close();

            }
            catch (SqlException)
            {
            }
            return ds;
        }

        public DataTable getJeniObat(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT RTRIM(LTRIM(kd_jns_obat)) AS kd_jns_obat, LTRIM(RTRIM(jns_obat)) AS jns_obat FROM jenis_obat WHERE stsaktif = '1' ORDER BY kd_jns_obat";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<---- Pilih ----->" };
                dt.Rows.InsertAt(drw, 0);
                cmb.DataSource = dt;
                cmb.DisplayMember = "jns_obat";
                cmb.ValueMember = "kd_jns_obat";
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
