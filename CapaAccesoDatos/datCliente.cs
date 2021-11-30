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
    public class datCliente
    {
        #region Singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }
        #endregion
        #region metodos
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.DNI = Convert.ToInt32(dr["DNI"]);
                    Cli.Apellidos = dr["Apellidos"].ToString();
                    Cli.Celular = Convert.ToInt32(dr["Celular"]);
                    Cli.EstadoCivil = Convert.ToBoolean(dr["EstadoCivil"]);
                    Cli.Fnacimiento = Convert.ToDateTime(dr["Fnacimiento"]);
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
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
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Apellidos", Cli.Apellidos);   
                cmd.Parameters.AddWithValue("@Celular", Cli.Celular);
                cmd.Parameters.AddWithValue("@EstadoCivil", Cli.EstadoCivil);
                cmd.Parameters.AddWithValue("@Fnacimiento", Cli.Fnacimiento);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
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
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Apellidos", Cli.Apellidos);
                cmd.Parameters.AddWithValue("@Celular", Cli.Celular);
                cmd.Parameters.AddWithValue("@EstadoCivil", Cli.EstadoCivil);
                cmd.Parameters.AddWithValue("@Fnacimiento", Cli.Fnacimiento);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
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
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
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
