using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCotizacion
    {
        public DateTime Fccotizacion { get; set; }

        public Double Valor { get; set; }

        public int MotoID { get; set; }

        public Boolean estCotizacion { get; set; }

        public int CotizacionID { get; set; }
    }
}
