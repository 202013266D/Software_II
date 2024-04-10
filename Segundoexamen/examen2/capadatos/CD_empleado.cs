using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capadatos
{
    public class CD_empleado
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable mostrar()
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "select * from empleado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nombre, string apellido, double sueldo, string categoria, double sueldoneto)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "Insetarempleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@sueldo", sueldo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@sueldoneto", sueldoneto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            
        }
        public void Editar(string nombre, string apellido, double sueldo, string categoria, double sueldoneto, int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "Editarempleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@sueldo", sueldo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@sueldoneto", sueldoneto);
            comando.Parameters.AddWithValue("@idemp", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
           
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "Eliminarempleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idemp", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
