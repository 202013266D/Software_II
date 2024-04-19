using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capadatos;

namespace capanegocio
{
    public class CN_Empleado
    {
        private CD_empleado objetoCD = new CD_empleado();
        public DataTable MostrarEmpleado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }
        public void Insertaremp(string nombre, string apellido, string sueldo, string categoria, string sueldoneto)
        {
            objetoCD.Insertar(nombre, apellido, Convert.ToDouble(sueldo), categoria, Convert.ToDouble(sueldoneto));
        }
        public void Editaremp(string nombre, string apellido, string sueldo, string categoria, string sueldoneto, string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToDouble(sueldo), categoria, Convert.ToDouble(sueldoneto), Convert.ToInt32(id));
        }
        public void Eliminaremp(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
