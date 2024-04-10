using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;

namespace capapresentacion
{
    public partial class Form1 : Form
    {
        CN_Empleado objetoCN = new CN_Empleado();
        private string idProducto = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }
        private void MostrarEmpleado()
        {
            CN_Empleado objeto = new CN_Empleado();
            dataGridView1.DataSource = objeto.MostrarEmpleado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                   //objetoCN.Insertaremp(txtnombre.Text, txtapellido.Text, txtsueldo, txtcategoria.Text, txtsueldoneto);
                    MessageBox.Show("se inserto correctamente");
                    MostrarEmpleado();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    //objetoCN.Editaremp(txtnombre.Text, txtapellido.Text, txtsueldo.Text, txtcategoria.Text, txtsueldoneto.Text, idProducto);
                    //objetoCN.Editaremp(txtnombre.Text, txtapellido.Text, txtsueldo, txtcategoria.Text, txtsueldoneto, idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarEmpleado();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        private void limpiarForm()
        {
            txtapellido.Clear();
            txtsueldo.Text = "";
            txtcategoria.Clear();
            txtsueldoneto.Clear();
            txtnombre.Clear();
        }
    }
}
