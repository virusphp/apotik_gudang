using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.Model.ModelSatuan
{
    class SatuanData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public SatuanData()
        {
            koneksi = konek();
        }

        public DataTable getSatuan(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT RTRIM(LTRIM(idsatuan)) AS idsatuan, RTRIM(LTRIM(nmsatuan)) AS nmsatuan FROM ap_satuan ORDER BY nmsatuan";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<---- Pilih ----->" };
                dt.Rows.InsertAt(drw, 0);
                cmb.DataSource = dt;
                cmb.DisplayMember = "nmsatuan";
                cmb.ValueMember = "idsatuan";
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

        public DataSet getAllSatuan(Satuan request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT idsatuan, nmsatuan FROM ap_satuan WHERE nmsatuan LIKE '%" + request.Cari + "%' ORDER BY idsatuan";
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

        
    }
}
