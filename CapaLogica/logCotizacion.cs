using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCotizacion
    {
        #region Singleton
        private static readonly logCotizacion _instancia = new logCotizacion();
        public static logCotizacion Instancia
        {
            get { return logCotizacion._instancia; }
        }
        #endregion
        #region metodos
        public List<entCotizacion> ListarCotizacion()
        {
            return datCotizacion.Instancia.ListarCotizacion();
        }

        public void insertaCotizacion(entCotizacion cot)
        {
            datCotizacion.Instancia.InsertarCotizacion(cot);
        }
        #endregion metodos
    }
}
