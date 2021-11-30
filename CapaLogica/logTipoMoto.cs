using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTipoMoto
    {
        #region Singleton
        private static readonly logTipoMoto _instancia = new logTipoMoto();
        public static logTipoMoto Instancia
        {
            get { return logTipoMoto._instancia; }
        }
        #endregion
        #region metodos


        public List<entTipoMoto> ListarTipoMoto()
        {
            return datTipoMoto.Instancia.ListarTipoMoto();
        }

        public void insertaTipoMoto(entTipoMoto cli)
        {
            datTipoMoto.Instancia.InsertarTipoMoto(cli);
        }

        public void EditaTipoMoto(entTipoMoto Cli)
        {
            datTipoMoto.Instancia.EditarTipoMoto(Cli);
        }
        public void DeshabilitarTipoMoto(entTipoMoto Cli)
        {
            datTipoMoto.Instancia.DeshabilitarTipoMoto(Cli);
        }
        #endregion metodos
    }
}
