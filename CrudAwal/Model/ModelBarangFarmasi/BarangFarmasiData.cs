using CrudAwal.koneksi;
using System.Data;
using System.Data.SqlClient;

namespace CrudAwal.Model.ModelBarangFarmasi
{
    class BarangFarmasiData : DBConnect
    {
        private SqlCommand command;
        private SqlConnection koneksi;
        private SqlDataAdapter adapter;
        private string query;

        public BarangFarmasiData()
        {
            koneksi = konek();
        }

        public DataSet getBarangByKode(BarangFarmasi request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT idx_barang, LTRIM(RTRIM(kd_satuan_besar)) AS kd_satuan_besar, harga_satuan_besar, senpotbeli," +
                    "hpp, ppn1, hrgsatbesarppn, isi_satuan_besar, LTRIM(RTRIM(kd_satuan_kecil)) AS kd_satuan_kecil," +
                    "harga_satuan_netto, harga_jual,ppn2, harga_satuan " +
                    "FROM barang_farmasi " +
                    "WHERE kd_barang='" + request.Cari + "' AND stsaktif='1' ORDER BY kd_barang";
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

        public DataSet getListBarang(BarangFarmasi request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT idx_barang,kd_barang,RTRIM(LTRIM(nama_barang)) AS nama_barang,harga_satuan_besar," +
                    "hrgsatbesarppn,RTRIM(LTRIM(keterangan)) AS keterangan, LTRIM(RTRIM(kd_satuan_kecil)) as kd_satuan_kecil " +
                    "FROM barang_farmasi " +
                    "WHERE nama_barang LIKE '%" + request.Cari + "%' AND stsaktif='1' ORDER BY kd_barang";
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

        public DataSet getBarangFarmasi(BarangFarmasi request)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT kd_barang, LTRIM(RTRIM(nama_barang)) AS nama_barang, " +
                    "LTRIM(RTRIM(kd_satuan_besar)) AS kd_satuan_besar, harga_satuan_besar, hrgsatbesarppn, " +
                    "isi_satuan_besar, LTRIM(RTRIM(kd_satuan_kecil)) as kd_satuan_kecil, harga_satuan_netto, harga_satuan, " +
                    "senpotbeli, harga_jual, " +
                    "LTRIM(RTRIM(keterangan)) AS keterangan, " +
                    "CASE stsaktif WHEN '1' THEN 'Aktif' ELSE 'Non Aktif' END AS stsaktif " +
                    "FROM barang_farmasi WHERE nama_barang LIKE '%" + request.Cari + "%' AND stsaktif='"+ request.Stsaktif +"' ORDER BY kd_barang";
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
