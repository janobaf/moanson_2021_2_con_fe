using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public DateTime Fcventa { get; set; }
        public int Hora { get; set; }
        public String Tipoventa { get; set; }
        public Boolean estVenta { set; get; }
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int CotizacionID { set; get; }
    }
}
