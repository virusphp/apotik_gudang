using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelJenisObat
{
    class JenisObat
    {
        private string cari, kd_jns_obat, jns_obat;

        public string Kd_jns_obat { get => kd_jns_obat; set => kd_jns_obat = value; }
        public string Jns_obat { get => jns_obat; set => jns_obat = value; }
        public string Cari { get => cari; set => cari = value; }
    }
}
