using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logVenta
    {
        private static readonly logVenta _instancia = new logVenta();
        public static logVenta Instancia
        {
            get { return logVenta._instancia; }
        }
        public List<entVenta> ListarVentas()
        {
            return datVenta.Instancia.ListarVentas();
        }


        public void EliminarVenta(entVenta ven)
        {
            datVenta.Instancia.EliminarVenta(ven);
        }

        public entVenta BuscarVenta(int idcliente)
        {
            entVenta venta = new entVenta();
            venta = datVenta.Instancia.BuscarVenta(idcliente);
            return venta;

        }
        public Boolean Verificar_cliente(int idcliente)
        {
            entCliente c = new entCliente();
            c = datVenta.Instancia.validarCliente(idcliente);
            Console.WriteLine(Convert.ToString(c.ClienteID), c.estCliente);
            if (c != null && c.estCliente == true)
                return true;
            return false;
        }
        public void InsertarVenta(entVenta ven)
        {
            datVenta.Instancia.InsertarVenta(ven);
        }
        public Boolean VerificarCotizacion(int cotizacionID)
        {
            entCotizacion c1 = new entCotizacion();
            c1 = datVenta.Instancia.validarCotizacion(cotizacionID);
            if (c1 != null && c1.estCotizacion == true)
                return true;
            return false;
        }
    }
}
