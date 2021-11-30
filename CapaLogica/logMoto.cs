using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logMoto
    {
        #region Singleton
        private static readonly logMoto _instancia = new logMoto();
        public static logMoto Instancia
        {
            get { return logMoto._instancia; }
        }
        #endregion
        #region metodos


        public List<entMoto> ListarMoto()
        {
            return datMoto.Instancia.ListarMoto();
        }

        public void insertaMoto(entMoto cli)
        {
            datMoto.Instancia.InsertarMoto(cli);
        }

        public void EditaMoto(entMoto Cli)
        {
            datMoto.Instancia.EditarMoto(Cli);
        }
        public void DeshabilitarMoto(entMoto Cli)
        {
            datMoto.Instancia.DeshabilitarMoto(Cli);
        }
        public entMoto BuscaridMoto(int MotoID)
        {
            try
            {
                return datMoto.Instancia.BuscaridMoto(MotoID);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
