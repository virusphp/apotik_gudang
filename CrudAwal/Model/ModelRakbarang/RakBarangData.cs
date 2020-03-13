using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.Model.ModelRakbarang
{
    class RakBarangData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public RakBarangData()
        {
            koneksi = konek();
        }

        public DataTable getRakbarang(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT noid, RTRIM(LTRIM(nmrakbarang)) AS nmrakbarang FROM ap_rakbarang order by nmrakbarang";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<---- Pilih ----->" };
                dt.Rows.InsertAt(drw, 0);
                cmb.DataSource = dt;
                cmb.DisplayMember = "nmrakbarang";
                cmb.ValueMember = "noid";
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

        public DataSet getRakBarangAll(RakBarang request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM ap_rakbarang WHERE nmrakbarang LIKE '%" + request.Cari + "%' ORDER BY noid";
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
