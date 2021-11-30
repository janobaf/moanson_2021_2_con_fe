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
    public class datVenta
    {
        private static readonly datVenta _instancia = new datVenta();
        public static datVenta Instancia
        {
            get { return datVenta._instancia; }
        }
        public List<entVenta> ListarVentas()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarventas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta ven = new entVenta();
                    ven.VentaID = Convert.ToInt32(dr["VentaID"]);
                    ven.Fcventa = Convert.ToDateTime(dr["Fcventa"]);
                    ven.Hora = Convert.ToInt32(dr["Hora"]);
                    ven.Tipoventa = dr["Tipoventa"].ToString();
                    ven.estVenta = Convert.ToBoolean(dr["estVenta"]);
                    ven.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    ven.CotizacionID = Convert.ToInt32(dr["CotizacionID"]);
                    lista.Add(ven);
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

        public void InsertarVenta(entVenta ven)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("crearVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fcventa", ven.Fcventa);
                cmd.Parameters.AddWithValue("@Hora", ven.Hora);
                cmd.Parameters.AddWithValue("@Tipoventa", ven.Tipoventa);
                cmd.Parameters.AddWithValue("@estVenta", ven.estVenta);
                cmd.Parameters.AddWithValue("@ClienteID", ven.ClienteID);
                cmd.Parameters.AddWithValue("@CotizacionID", ven.CotizacionID);


                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }


        public void EliminarVenta(entVenta ven)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("eliminarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VentaID", ven.VentaID);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

        public entCliente validarCliente(int ClienteID)
        {
            SqlCommand cmd = null;
            entCliente cliente = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("validar_cliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cliente.ClienteID = ClienteID;
                    cliente.estCliente = Convert.ToBoolean(dr["estCliente"]);

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
            return cliente;
        }

        public entCotizacion validarCotizacion(int CotizaciionID)
        {
            SqlCommand cmd = null;
            entCotizacion cotizacion = new entCotizacion();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("validar_cotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CotizacionID", CotizaciionID);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    cotizacion.CotizacionID = Convert.ToInt32(dr["CotizacionID"]);
                    cotizacion.estCotizacion = Convert.ToBoolean(dr["estCotizacion"]);
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
            return cotizacion;
        }

        public entVenta BuscarVenta(int ventaID)
        {
            SqlCommand cmd = null;
            entVenta venta = new entVenta();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("buscarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    venta.Fcventa = Convert.ToDateTime(dr["Fcventa"]);
                    venta.Hora = Convert.ToInt32(dr["Hora"]);
                    venta.Tipoventa = dr["Tipoventa"].ToString();
                    venta.estVenta = Convert.ToBoolean(dr["estVenta"]);
                    venta.VentaID = Convert.ToInt32(dr["VentaID"]);
                    venta.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    venta.CotizacionID = Convert.ToInt32(dr["CotizacionID"]);

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
            return venta;
        }
    }
}
