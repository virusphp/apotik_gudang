using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelRakbarang
{
    class RakBarang
    {
        private string cari, noid, nmrakbarang;

        public string Noid { get => noid; set => noid = value; }
        public string Nmrakbarang { get => nmrakbarang; set => nmrakbarang = value; }
        public string Cari { get => cari; set => cari = value; }
    }
}
