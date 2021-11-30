using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoMoto
    {
        public String Nombre { get; set; }
        public double Velomaxima { get; set; }
        public double Pesomaximo { get; set; }
        public int MotormotoID { get; set; }
        public Boolean estTipoMoto { get; set; }
        public int TipomotoID { get; set; }
    }
}
