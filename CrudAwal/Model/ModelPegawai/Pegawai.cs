using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal
{
    class Pegawai
    {
        private string kd_pegawai, nip, nama_pegawai;

        public string Kd_pegawai
        {
            get { return kd_pegawai; }
            set { kd_pegawai = value; }
        }

        public string Nip
        {
            get { return nip; }
            set { nip = value; }
        }

        public string Nama_pegawai
        {
            get { return nama_pegawai; }
            set { nama_pegawai = value; }
        }

    }
}
