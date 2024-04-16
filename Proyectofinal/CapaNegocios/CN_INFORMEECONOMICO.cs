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
    public class CN_INFORMEECONOMICO
    {
        private CD_INFORMEECONOMICO objetoCD = new CD_INFORMEECONOMICO();
        public DataTable Mostrarinformeeconomico( string idalum)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarinfor(Convert.ToInt32(idalum));
            return tabla;
        }
        public void Insertarpago(string codigo, string cuota, string descuento, string periodo, string montoapagar, string fechapago, string ConceptoContable, string importedemes)
        {
            objetoCD.InsertarPA(Convert.ToInt32(codigo), Convert.ToInt32(cuota), Convert.ToDouble(descuento), periodo, Convert.ToDouble(montoapagar), Convert.ToDateTime(fechapago), ConceptoContable, Convert.ToDouble(importedemes));
        }

        public void Editarpago(string codigo, string cuota, string descuento, string periodo, string montoapagar, string fechapago, string ConceptoContable, string importedemes, string idmensualidad)
        {
            objetoCD.EditarPA(Convert.ToInt32(codigo), Convert.ToInt32(cuota), Convert.ToDouble(descuento), periodo, Convert.ToDouble(montoapagar), Convert.ToDateTime(fechapago), ConceptoContable, Convert.ToDouble(importedemes), Convert.ToInt32(idmensualidad));
        }
    }
}
