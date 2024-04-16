using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Registroalumno : Form
    {
        CN_INFORMEECONOMICO objeto = new CN_INFORMEECONOMICO();
        CN_Alumno objetoCN = new CN_Alumno();
        private string idalum = null;
        private bool Editar = false;

        public Registroalumno()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                string idalum = dataGridView1.Rows[e.RowIndex].Cells["AlumnoID"].Value.ToString();

                MostrarInformeEconomico(idalum);
            }

        }
        private void MostrarInformeEconomico(string idalum)
        {
           
            informeeconomico informeForm = new informeeconomico();
                   
            CN_INFORMEECONOMICO objeto = new CN_INFORMEECONOMICO();
            DataTable informeData = objeto.Mostrarinformeeconomico(idalum);
            informeForm.SetDatosInforme(informeData);                    
            informeForm.ShowDialog();
        }
        

        private void Registroalumno_Load(object sender, EventArgs e)
        {
            MostrarAlumno();
        }
        private void MostrarAlumno()
        {
            CN_Alumno objeto = new CN_Alumno();
            dataGridView1.DataSource = objeto.MostrarAlumno();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarAlum(txtnombre.Text, txtapellido.Text, txtfechanaci.Text, txtgenero.Text, txtdireccion.Text, txttelefono.Text, txtcorreo.Text, txtingreso.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarAlumno();
                    limpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
             if (Editar == true)
            {
                try
                {
                    objetoCN.EditareAlum(txtnombre.Text, txtapellido.Text, txtfechanaci.Text, txtgenero.Text, txtdireccion.Text, txttelefono.Text, txtcorreo.Text, txtingreso.Text,idalum);
                    MessageBox.Show("se edito correctamente");
                    MostrarAlumno();
                    limpiarFormulario();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void limpiarFormulario()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtfechanaci.Clear();
            txtgenero.Clear();
            txtingreso.Clear();
            txttelefono.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtdireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtfechanaci.Text = dataGridView1.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                txtingreso.Text = dataGridView1.CurrentRow.Cells["FechaIngreso"].Value.ToString();
                txtgenero.Text = dataGridView1.CurrentRow.Cells["Genero"].Value.ToString();
                txttelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                idalum = dataGridView1.CurrentRow.Cells["AlumnoID"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idalum = dataGridView1.CurrentRow.Cells["AlumnoID"].Value.ToString();
                objetoCN.Eliminaremp(idalum);
                MessageBox.Show("Eliminado correctamente");
                MostrarAlumno();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
