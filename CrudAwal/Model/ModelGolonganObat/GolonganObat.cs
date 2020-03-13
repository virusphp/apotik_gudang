using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAwal.Model.ModelGolonganObat
{
    class GolonganObat
    {
        private string kd_gol_obat, gol_obat;

        public string Kd_gol_obat { get => kd_gol_obat; set => kd_gol_obat = value; }
        public string Gol_obat { get => gol_obat; set => gol_obat = value; }
    }
}
