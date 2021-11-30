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
    public class datTipoMoto
    {
        #region Singleton
        private static readonly datTipoMoto _instancia = new datTipoMoto();
        public static datTipoMoto Instancia
        {
            get { return datTipoMoto._instancia; }
        }
        #endregion
        #region metodos
        public List<entTipoMoto> ListarTipoMoto()
        {
            SqlCommand cmd = null;
            List<entTipoMoto> lista = new List<entTipoMoto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoMoto Cli = new entTipoMoto();
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.Velomaxima = Convert.ToDouble(dr["Velomaxima"]);
                    Cli.Pesomaximo = Convert.ToDouble(dr["Pesomaximo"]);
                    Cli.estTipoMoto = Convert.ToBoolean(dr["estTipoMoto"]);
                    Cli.TipomotoID = Convert.ToInt32(dr["TipomotoID"]);
                    Cli.MotormotoID = Convert.ToInt32(dr["MotormotoID"]);
                    lista.Add(Cli);
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
        public Boolean InsertarTipoMoto(entTipoMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Velomaxima", Cli.Velomaxima);
                cmd.Parameters.AddWithValue("@Pesomaximo", Cli.Pesomaximo);
                cmd.Parameters.AddWithValue("@estTipoMoto", Cli.estTipoMoto);
                cmd.Parameters.AddWithValue("@MotormotoID", Cli.TipomotoID);
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
        public Boolean EditarTipoMoto(entTipoMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Velomaxima", Cli.Velomaxima);
                cmd.Parameters.AddWithValue("@Pesomaximo", Cli.Pesomaximo);
                cmd.Parameters.AddWithValue("@estTipoMoto", Cli.estTipoMoto);
                cmd.Parameters.AddWithValue("@TipomotoID", Cli.TipomotoID);
                cmd.Parameters.AddWithValue("@MotormotoID", Cli.MotormotoID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean DeshabilitarTipoMoto(entTipoMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarTipoMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipomotoID", Cli.TipomotoID);
                cmd.Parameters.AddWithValue("@estTipoMoto", Cli.estTipoMoto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion Metodos
    }
}
