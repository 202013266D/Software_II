using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capadatos
{
    class CD_Conexion
    {
     
            private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-22UD4R3;DataBase= empresa2;Integrated Security=true");
            public SqlConnection abrirconexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }
            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        }
    }

