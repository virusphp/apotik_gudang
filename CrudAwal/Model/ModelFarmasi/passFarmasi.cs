using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal
{
    class passFarmasi
    {
        private string uid, kdkasir, nmkasir, hak_akses, pasword;

        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public string Kdkasir
        {
            get { return kdkasir; }
            set { kdkasir = value; }
        }

        public string Nmkasir
        {
            get { return nmkasir; }
            set { nmkasir = value; }
        }

        public string Hak_akses
        {
            get { return hak_akses; }
            set { hak_akses = value; }
        }

        public string Pasword
        {
            get { return pasword; }
            set { pasword = value; }
        }
    }
}
