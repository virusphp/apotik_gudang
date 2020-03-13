using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelBarangFarmasi
{
    class BarangFarmasi
    {
        private string cari, kd_barang, kd_kel_obat, kd_jns_obat, kd_gol_obat, nama_barang, kdpabrik, generik, formularium, 
                dosis, satdosis, kd_satuan_besar, harga_satuan_besar, senpotbeli, hpp, hrgsatbesarppn, isi_satuan_besar,
                kd_satuan_kecil, harga_satuan_netto, harga_jual, ppn2, harga_satuan, stok_min, kd_lokasi, keteranga, stsaktif;

        public string Kd_barang { get => kd_barang; set => kd_barang = value; }
        public string Kd_kel_obat { get => kd_kel_obat; set => kd_kel_obat = value; }
        public string Kd_jns_obat { get => kd_jns_obat; set => kd_jns_obat = value; }
        public string Kd_gol_obat { get => kd_gol_obat; set => kd_gol_obat = value; }
        public string Nama_barang { get => nama_barang; set => nama_barang = value; }
        public string Kdpabrik { get => kdpabrik; set => kdpabrik = value; }
        public string Generik { get => generik; set => generik = value; }
        public string Formularium { get => formularium; set => formularium = value; }
        public string Dosis { get => dosis; set => dosis = value; }
        public string Satdosis { get => satdosis; set => satdosis = value; }
        public string Kd_satuan_besar { get => kd_satuan_besar; set => kd_satuan_besar = value; }
        public string Harga_satuan_besar { get => harga_satuan_besar; set => harga_satuan_besar = value; }
        public string Senpotbeli { get => senpotbeli; set => senpotbeli = value; }
        public string Hpp { get => hpp; set => hpp = value; }
        public string Hrgsatbesarppn { get => hrgsatbesarppn; set => hrgsatbesarppn = value; }
        public string Isi_satuan_besar { get => isi_satuan_besar; set => isi_satuan_besar = value; }
        public string Kd_satuan_kecil { get => kd_satuan_kecil; set => kd_satuan_kecil = value; }
        public string Harga_satuan_netto { get => harga_satuan_netto; set => harga_satuan_netto = value; }
        public string Harga_jual { get => harga_jual; set => harga_jual = value; }
        public string Ppn2 { get => ppn2; set => ppn2 = value; }
        public string Harga_satuan { get => harga_satuan; set => harga_satuan = value; }
        public string Stok_min { get => stok_min; set => stok_min = value; }
        public string Kd_lokasi { get => kd_lokasi; set => kd_lokasi = value; }
        public string Keteranga { get => keteranga; set => keteranga = value; }
        public string Stsaktif { get => stsaktif; set => stsaktif = value; }
        public string Cari { get => cari; set => cari = value; }
    }
}
