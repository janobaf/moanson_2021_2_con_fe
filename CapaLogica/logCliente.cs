using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente
    {
        #region Singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }
        #endregion

        #region metodos
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        public void insertacliente(entCliente cli)
        {
            datCliente.Instancia.InsertarCliente(cli);
        }

        public void EditaCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }
        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }
        #endregion metodos
    }
}
