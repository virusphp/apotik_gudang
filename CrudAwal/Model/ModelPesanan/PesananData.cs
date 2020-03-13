using CrudAwal.koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelPesanan
{
    class PesananData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public PesananData()
        {
            koneksi = konek();
        }

        public DataSet getNomorSP(Pesanan request)
        {
            
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT MAX(notasp) as notasp FROM ap_pesanbrg " +
                    "WHERE YEAR(tanggal) ='" + request.Tanggal_akhir + "' AND MONTH(tanggal)='" + request.Tanggal_awal + "'";
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

        public DataSet getPesanan(Pesanan request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT pas.nmkasir, psn.tanggal, psn.notasp, psn.jns_obat, psn.nmsuplier, psn.kd_barang, psn.nama_barang," +
                    "psn.harga, psn.jml, psn.nmsatuan, psn.jmlharga, psn.ttlmasuk, psn.ttlsisa, psn.stspesan FROM ap_pesanbrg as psn " +
                    "JOIN ap_pas_farmasi as pas ON psn.kdkasir = pas.kdkasir " +
                    "WHERE psn.nama_barang LIKE '%" + request.Cari + "%' AND tanggal >='" + request.Tanggal_awal + "' AND tanggal <='" + request.Tanggal_akhir + "' AND psn.jns_obat LIKE '%" + request.Jenis_obat + "%'" +
                    "OR psn.nmsuplier LIKE '%" + request.Cari + "%' AND tanggal >='" + request.Tanggal_awal + "' AND tanggal <='" + request.Tanggal_akhir + "' AND psn.jns_obat LIKE '%" + request.Jenis_obat + "%'" +
                    "OR psn.notasp LIKE '%" + request.Cari + "%' AND tanggal >='" + request.Tanggal_awal + "' AND tanggal <='" + request.Tanggal_akhir + "' AND psn.jns_obat LIKE '%" + request.Jenis_obat + "%' ORDER BY psn.tanggal";

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
