using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logMotor
    {
        #region Singleton
        private static readonly logMotor _instancia = new logMotor();
        public static logMotor Instancia
        {
            get { return logMotor._instancia; }
        }
        #endregion
        #region metodos


        public List<entMotor> ListarMotor()
        {
            return datMotor.Instancia.ListarMotor();
        }

        public void insertaMotor(entMotor cli)
        {
            datMotor.Instancia.InsertarMotor(cli);
        }

        public void EditaMotor(entMotor Cli)
        {
            datMotor.Instancia.EditarMotor(Cli);
        }
        public void DeshabilitarMotor(entMotor Cli)
        {
            datMotor.Instancia.DeshabilitarMotor(Cli);
        }
        #endregion metodos
    }
}
