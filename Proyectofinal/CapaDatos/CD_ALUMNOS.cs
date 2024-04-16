using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_ALUMNOS
    {
        private CD_conexion conexion = new CD_conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable mostrar()
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "select * from Alumnos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string Nombre,string Apellido,DateTime FechaNacimiento,string Genero,string Direccion, string Telefono,string CorreoElectronico,DateTime FechaIngreso)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "InsetarAlumnos"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono); 
            comando.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
            comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(string Nombre,string Apellido,DateTime FechaNacimiento,string Genero,string Direccion, string Telefono,string CorreoElectronico,DateTime FechaIngreso,int idalum)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "EditarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
            comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comando.Parameters.AddWithValue("@idAlumno", idalum);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "EliminarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAlumno", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
