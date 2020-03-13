using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAwal.Model.ModelPabrik
{
    class PabrikData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public PabrikData()
        {
            koneksi = konek();
        }

        public DataTable getPabrik(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT RTRIM(LTRIM(kdpabrik)) AS kdpabrik, RTRIM(LTRIM(nmpabrik)) AS nmpabrik FROM ap_pabrik ORDER BY kdpabrik";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<---- Pilih ----->" };
                dt.Rows.InsertAt(drw, 0);
                cmb.DataSource = dt;
                cmb.DisplayMember = "nmpabrik";
                cmb.ValueMember = "kdpabrik";
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

        public DataSet getAllPabrik(Pabrik request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT kdpabrik, nmpabrik FROM ap_pabrik WHERE nmpabrik LIKE '%" + request.Cari + "%' ORDER BY kdpabrik";
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
