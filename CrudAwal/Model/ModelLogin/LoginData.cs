using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelLogin
{
    class LoginData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public LoginData()
        {
            koneksi = konek();
        }

        public DataTable loginUser(Login login)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "select apf.uid, apf.kdkasir, apf.nmkasir, apf.hak_akses, p.foto from ap_pas_farmasi as apf inner join pegawai as p on apf.uid = p.kd_pegawai  where uid='" + login.Username + "' and pasword='"+ login.Password +"'";
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

        public DataTable getFoto(Login login)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            try
            {
                query = "SELECT foto,nama_pegawai,nip FROM Pegawai where kd_pegawai='"+ login.Username + "'";
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
    }
}
