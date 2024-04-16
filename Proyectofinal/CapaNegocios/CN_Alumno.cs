using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Alumno
    {
        private CD_ALUMNOS objetoCD = new CD_ALUMNOS();
        public DataTable MostrarAlumno()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }
        public void InsertarAlum(string Nombre, string Apellido, string FechaNacimiento, string Genero, string Direccion, string Telefono, string CorreoElectronico,string FechaIngreso)
        {
            objetoCD.Insertar(Nombre, Apellido, Convert.ToDateTime(FechaNacimiento), Genero, Direccion, Telefono, CorreoElectronico, Convert.ToDateTime(FechaIngreso));
        }
        public void EditareAlum(string Nombre, string Apellido, string FechaNacimiento, string Genero, string Direccion, string Telefono, string CorreoElectronico, string FechaIngreso, string idalum)
        {
            objetoCD.Editar(Nombre, Apellido, Convert.ToDateTime(FechaNacimiento), Genero, Direccion, Telefono, CorreoElectronico, Convert.ToDateTime(FechaIngreso), Convert.ToInt32(idalum));
        }
        public void Eliminaremp(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
