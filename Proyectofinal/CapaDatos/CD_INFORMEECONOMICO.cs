using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CD_INFORMEECONOMICO
    {
        private CD_conexion conexion = new CD_conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable mostrarinfor(int idalum)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "ListarPagosPorAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAlumno", idalum);                        
            SqlDataReader reader = comando.ExecuteReader();            
            tabla.Load(reader);          
            conexion.CerrarConexion();
            comando.Parameters.Clear();            
            return tabla;
        }
        public void InsertarPA(int codigo, int cuota, double descuento, string periodo, double montoapagar, DateTime fechapago, string ConceptoContable,double importedemes)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "InsertarPagos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigoalumn", codigo);
            comando.Parameters.AddWithValue("@Cuota", cuota);
            comando.Parameters.AddWithValue("@PorcentajeDescuento", descuento);
            comando.Parameters.AddWithValue("@Periodo", periodo);
            comando.Parameters.AddWithValue("@MontoAPagar", montoapagar);
            comando.Parameters.AddWithValue("@FechaPago", fechapago);
            comando.Parameters.AddWithValue("@ConceptoContable", ConceptoContable);
            comando.Parameters.AddWithValue("@ImpConcepto", importedemes);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarPA(int codigo, int cuota, double descuento, string periodo, double montoapagar, DateTime fechapago, string ConceptoContable, double importedemes, int idmensualidad)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "EditarPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigoalumn", codigo);
            comando.Parameters.AddWithValue("@Cuota", cuota);
            comando.Parameters.AddWithValue("@PorcentajeDescuento", descuento);
            comando.Parameters.AddWithValue("@Periodo", periodo);
            comando.Parameters.AddWithValue("@MontoAPagar", montoapagar);
            comando.Parameters.AddWithValue("@FechaPago", fechapago);
            comando.Parameters.AddWithValue("@ConceptoContable", ConceptoContable);
            comando.Parameters.AddWithValue("@ImpConcepto", importedemes);
            comando.Parameters.AddWithValue("@MensualidadID", idmensualidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
