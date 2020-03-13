using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelPesanan
{
    class Pesanan
    {
        private String cari, petugas, tanggal_awal, tanggal_akhir, notasp, jenis_obat, suplier, kd_barang, nama_barang, harga, jumlah, satuan, jumlah_harga, total_masuk, total_sisa, status_pesan;

        public string Cari { get => cari; set => cari = value; }
        public string Petugas { get => petugas; set => petugas = value; }
        public string Notasp { get => notasp; set => notasp = value; }
        public string Jenis_obat { get => jenis_obat; set => jenis_obat = value; }
        public string Suplier { get => suplier; set => suplier = value; }
        public string Kd_barang { get => kd_barang; set => kd_barang = value; }
        public string Nama_barang { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Satuan { get => satuan; set => satuan = value; }
        public string Jumlah_harga { get => jumlah_harga; set => jumlah_harga = value; }
        public string Total_masuk { get => total_masuk; set => total_masuk = value; }
        public string Total_sisa { get => total_sisa; set => total_sisa = value; }
        public string Status_pesan { get => status_pesan; set => status_pesan = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Tanggal_awal { get => tanggal_awal; set => tanggal_awal = value; }
        public string Tanggal_akhir { get => tanggal_akhir; set => tanggal_akhir = value; }

    }
}
