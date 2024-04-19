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
        private string idempleado = null;
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
                   objetoCN.Insertaremp(txtnombre.Text, txtapellido.Text, txtsueldo.Text, txtcategoria.Text, txtsueldoneto.Text);
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
                    objetoCN.Editaremp(txtnombre.Text, txtapellido.Text, txtsueldo.Text, txtcategoria.Text, txtsueldoneto.Text, idempleado);
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
       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                txtsueldo.Text = dataGridView1.CurrentRow.Cells["sueldo"].Value.ToString();
                txtcategoria.Text = dataGridView1.CurrentRow.Cells["categoria"].Value.ToString();
                txtsueldoneto.Text = dataGridView1.CurrentRow.Cells["sueldoneto"].Value.ToString();
                idempleado = dataGridView1.CurrentRow.Cells["idempleado"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void limpiarForm()
        {
            txtapellido.Clear();
            txtsueldo.Text = "";
            txtcategoria.Clear();
            txtsueldoneto.Clear();
            txtnombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idempleado = dataGridView1.CurrentRow.Cells["idempleado"].Value.ToString();
                objetoCN.Eliminaremp(idempleado);
                MessageBox.Show("Eliminado correctamente");
                    MostrarEmpleado();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        }

    }

