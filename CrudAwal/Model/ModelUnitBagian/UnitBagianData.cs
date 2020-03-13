using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelUnitBagian
{
    class UnitBagianData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public UnitBagianData()
        {
            koneksi = konek();
        }

        public DataSet getUnitBagian(UnitBagian request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT kdbagian, nmbagian FROM ap_bagian WHERE nmbagian LIKE '%" + request.Cari + "%' ORDER BY kdbagian";
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
