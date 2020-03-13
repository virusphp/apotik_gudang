using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal
{
    class FarmasiData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        // constructor
        public FarmasiData()
        {
            koneksi = konek();
        }

        // Get Semua data farmasi
        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "select uid, kdkasir, nmkasir, " +
                        "case when hak_akses = 1 then 'Operator'" +
                        "else 'Admin' end as hak_akses from ap_pas_farmasi";
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

        // Pencarian data farmasi berdasarkan nama likes
        public DataTable cariData(string search)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "select uid, kdkasir, nmkasir, hak_akses from ap_pas_farmasi where nmkasir LIKE '%" + search + "%'";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
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
        
        // pencarian data user farmasi berdasarkan kdkasir = 
        public DataTable getUser(string search)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                string query = "select kdkasir, nmkasir from ap_pas_farmasi where kdkasir='" + search+"'";
                command = new SqlCommand(query, koneksi);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
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

        // insert data user farmasi 
        public bool insertData(passFarmasi pf)
        {
            Boolean stat = false;
            try
            {
                query = "insert into ap_pas_farmasi (kdkasir, pasword, nmkasir, uid, hak_akses) values (@kdkasir, @pasword, @nmkasir, @uid, @hak_akses)";
                command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@kdkasir", pf.Kdkasir);
                command.Parameters.AddWithValue("@pasword", pf.Pasword);
                command.Parameters.AddWithValue("@nmkasir", pf.Nmkasir);
                command.Parameters.AddWithValue("@uid", pf.Uid);
                command.Parameters.AddWithValue("@hak_akses", pf.Hak_akses);

                koneksi.Open();
                int rows = command.ExecuteNonQuery();
                if (rows>0)
                {
                    stat = true;
                }
                else
                {
                    stat = false;
                }
            }
            catch (SqlException)
            {
                
            }
            finally
            {
                koneksi.Close();
            }
            return stat;
        }
    }
}
