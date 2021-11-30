using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logMarca
    {
        #region Singleton
        private static readonly logMarca _instancia = new logMarca();
        public static logMarca Instancia
        {
            get { return logMarca._instancia; }
        }
        #endregion
        #region metodos


        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarca();
        }

        public void insertaMarca(entMarca cli)
        {
            datMarca.Instancia.InsertarMarca(cli);
        }

        public void EditaMarca(entMarca Cli)
        {
            datMarca.Instancia.EditarMarca(Cli);
        }
        public void DeshabilitarMarca(entMarca Cli)
        {
            datMarca.Instancia.DeshabilitarMarca(Cli);
        }
        #endregion metodos
    }
}
