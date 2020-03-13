using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelSuplier
{
    class Suplier
    {
        private string cari, kdsuplier, nmsuplier, alamat, telpon;

        public string Cari { get => cari; set => cari = value; }
        public string Kdsuplier { get => kdsuplier; set => kdsuplier = value; }
        public string Nmsuplier { get => nmsuplier; set => nmsuplier = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Telpon { get => telpon; set => telpon = value; }
    }
}
