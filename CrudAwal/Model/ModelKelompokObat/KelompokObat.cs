using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelKelompokObat
{
    class KelompokObat
    {
        private string kd_kel_obat, kel_obat;

        public string Kd_kel_obat { get => kd_kel_obat; set => kd_kel_obat = value; }
        public string Kel_obat { get => kel_obat; set => kel_obat = value; }
    }
}
