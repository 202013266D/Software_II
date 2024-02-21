using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class venta
    {
        public void insercion_ventas(Objinterfaz ventas) {
            using (var  bd = new pruebaentities()){
                bd.ventas.add(ventas);
                bd.saveChanges();

            }
        }
    }
}
