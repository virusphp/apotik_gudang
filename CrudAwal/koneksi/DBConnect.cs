using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.IO;

namespace CrudAwal.koneksi
{
    class DBConnect
    {
        string konfigurasi;
        //SqlConnection kon;

        public DBConnect()
        {
            konek();
        }

        public SqlConnection konek()
        {
            readSetting();
            return new SqlConnection(konfigurasi);
        }

        private void readSetting()
        {
            Configuration config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(@".\config.json"));
            konfigurasi = config.stringKoneksi;
        }
    }
}
