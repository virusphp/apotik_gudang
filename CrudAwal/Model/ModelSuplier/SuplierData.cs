using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelSuplier
{

    class SuplierData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public SuplierData()
        {
            koneksi = konek();
        }

        public DataSet getListSuplier(Suplier request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT RTRIM(LTRIM(kdsuplier)) AS kdsuplier, RTRIM(LTRIM(nmsuplier)) AS nmsuplier FROM ap_suplier WHERE nmsuplier LIKE '%" + request.Cari + "%' ORDER BY kdsuplier";
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

        public DataSet getSuplier(Suplier request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT kdsuplier, nmsuplier, alamat, telpon FROM ap_suplier WHERE nmsuplier LIKE '%" + request.Cari + "%' ORDER BY kdsuplier";
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
