using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datCotizacion
    {
        #region Singleton
        private static readonly datCotizacion _instancia = new datCotizacion();
        public static datCotizacion Instancia
        {
            get { return datCotizacion._instancia; }
        }
        #endregion

        #region metodos
        public List<entCotizacion> ListarCotizacion()
        {
            SqlCommand cmd = null;
            List<entCotizacion> lista = new List<entCotizacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCotizacion Cot = new entCotizacion();

                    Cot.Fccotizacion = Convert.ToDateTime(dr["Fccotizacion"]);
                    Cot.Valor = Convert.ToDouble(dr["Valor"]);
                    Cot.MotoID = Convert.ToInt32(dr["MotoID"]);
                    Cot.estCotizacion = Convert.ToBoolean(dr["estCotizacion"]);
                    Cot.CotizacionID = Convert.ToInt32(dr["CotizacionID"]);
                    lista.Add(Cot);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarCotizacion(entCotizacion Cot)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fccotizacion", Cot.Fccotizacion);
                cmd.Parameters.AddWithValue("@Valor", Cot.Valor);
                cmd.Parameters.AddWithValue("@MotoID", Cot.MotoID);
                cmd.Parameters.AddWithValue("@estCotizacion", Cot.estCotizacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        #endregion
    }
}
