using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CrudAwal.koneksi;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;

namespace CrudAwal
{
    // Kelas
    class PegawaiData : DBConnect
    {

        //string konfigurasi = "server=localhost;port=3306;uid=root;pwd=;database=bebas";
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        // Kontruktur likes php __constuct()
        public PegawaiData()
        {
            //DBConnect konek = new DBConnect();
            koneksi = konek();
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "select nip, kd_pegawai,  nama_pegawai from pegawai";
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

        public DataTable cariData(string search)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "select kd_pegawai, nip, nama_pegawai from pegawai where nama_pegawai LIKE '%" + search + "%'";
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

        public bool insertData(Pegawai pg)
        {
            Boolean stat = false;
            try
            {
              
            }
            catch (SqlException)
            {
            }
            return stat;
        }

        public bool deleteData(string nip)
        {
            Boolean stat = false;
            try
            {
            }
            catch (SqlException)
            {
            }
            return stat;
        }

        public bool updateData(Pegawai pg, string nip)
        {
            Boolean stat = false;
            try
            {
              
            }
            catch (SqlException)
            {
            }
            return stat;
        }

    }
}
