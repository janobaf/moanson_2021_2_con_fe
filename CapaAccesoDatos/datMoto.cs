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
    public class datMoto
    {
        #region Singleton
        private static readonly datMoto _instancia = new datMoto();
        public static datMoto Instancia
        {
            get { return datMoto._instancia; }
        }
        #endregion
        #region metodos
        public List<entMoto> ListarMoto()
        {
            SqlCommand cmd = null;
            List<entMoto> lista = new List<entMoto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMoto Cli = new entMoto();
                    Cli.Disponibilidad = Convert.ToBoolean(dr["Disponibilidad"]);
                    Cli.Cantdispomoto = Convert.ToInt32(dr["Cantdispomoto"]);
                    Cli.estMoto = Convert.ToBoolean(dr["estMoto"]);
                    Cli.MotoID = Convert.ToInt32(dr["MotoID"]);
                    Cli.MarcamotoID = Convert.ToInt32(dr["MarcamotoID"]);
                    Cli.TipomotoID = Convert.ToInt32(dr["TipomotoID"]);
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
        public Boolean InsertarMoto(entMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Disponibilidad", Cli.Disponibilidad);
                cmd.Parameters.AddWithValue("@Cantdispomoto", Cli.Cantdispomoto);
                cmd.Parameters.AddWithValue("@estMoto", Cli.estMoto);
                cmd.Parameters.AddWithValue("@MarcamotoID", Cli.MarcamotoID);
                cmd.Parameters.AddWithValue("@TipomotoID", Cli.TipomotoID);
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
        public Boolean EditarMoto(entMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Disponibilidad", Cli.Disponibilidad);
                cmd.Parameters.AddWithValue("@Cantdispomoto", Cli.Cantdispomoto);
                cmd.Parameters.AddWithValue("@estMoto", Cli.estMoto);
                cmd.Parameters.AddWithValue("@MotoID", Cli.MotoID);
                cmd.Parameters.AddWithValue("@MarcamotoID", Cli.MarcamotoID);
                cmd.Parameters.AddWithValue("@TipomotoID", Cli.TipomotoID);
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
        public Boolean DeshabilitarMoto(entMoto Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MotoID", Cli.MotoID);
                cmd.Parameters.AddWithValue("@estMoto", Cli.estMoto);
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
        public entMoto BuscaridMoto(int MotoID)
        {
            SqlCommand cmd = null;
            entMoto Prod = new entMoto();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaridMoto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@spidMoto", MotoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prod.Disponibilidad = Convert.ToBoolean(dr["Disponibilidad"]);
                    Prod.Cantdispomoto = Convert.ToInt32(dr["Cantdispomoto"]);
                    Prod.estMoto = Convert.ToBoolean(dr["estMoto"]);
                    Prod.MotoID = Convert.ToInt32(dr["MotoID"]);
                    Prod.MarcamotoID = Convert.ToInt32(dr["MarcamotoID"]);
                    Prod.TipomotoID = Convert.ToInt32(dr["TipomotoID"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Prod;

        }

        #endregion Metodos
    }
}
