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
    public partial class informeeconomico : Form
    {
        CN_INFORMEECONOMICO objetoCN = new CN_INFORMEECONOMICO();
        private string idmensualidad = null;
        private bool Editar = false;
        public informeeconomico()
        {
            InitializeComponent();
        }
            
        
        private void linkprincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void informeeconomico_Load(object sender, EventArgs e)
        {

            
        }
        public void SetDatosInforme(DataTable informeData)
        {
            dataGridViewinforme.DataSource = informeData;
            dataGridViewinforme.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridViewinforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.Insertarpago(txtcodigoalumno.Text,txtcuota.Text,txtdescuento.Text,txtperiodo.Text,txtmontopagar.Text,txtfechapago.Text,txtconceptopago.Text,txtimportemes.Text);
                    MessageBox.Show("se inserto correctamente");
                    Mostrarinforme();
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
                    objetoCN.Editarpago(txtcodigoalumno.Text,txtcuota.Text,txtdescuento.Text,txtperiodo.Text,txtmontopagar.Text,txtfechapago.Text,txtconceptopago.Text,txtimportemes.Text,idmensualidad);
                    MessageBox.Show("se edito correctamente");
                    Mostrarinforme();
                    limpiarFormulario();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        
        private void Mostrarinforme()
        {
            CN_INFORMEECONOMICO objeto = new CN_INFORMEECONOMICO();
            DataTable informeData = objeto.Mostrarinformeeconomico(idmensualidad);
            SetDatosInforme(informeData);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void limpiarFormulario()
        {
            txtcodigoalumno.Clear();
            txtcuota.Clear();
            txtdescuento.Clear();
            txtperiodo.Clear();
            txtmontopagar.Clear();
            txtfechapago.Clear();
            txtconceptopago.Clear();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewinforme.SelectedRows.Count > 0)
            {
                Editar = true;
                txtcodigoalumno.Text = dataGridViewinforme.CurrentRow.Cells["AlumnoID"].Value.ToString();
                txtcuota.Text = dataGridViewinforme.CurrentRow.Cells["Cuota"].Value.ToString();
                txtdescuento.Text = dataGridViewinforme.CurrentRow.Cells["MontoDescuento"].Value.ToString();
                txtperiodo.Text = dataGridViewinforme.CurrentRow.Cells["Periodo"].Value.ToString();
                txtmontopagar.Text = dataGridViewinforme.CurrentRow.Cells["Importedepagado"].Value.ToString();
                txtfechapago.Text = dataGridViewinforme.CurrentRow.Cells["FechaPago"].Value.ToString();
                txtconceptopago.Text = dataGridViewinforme.CurrentRow.Cells["ConceptoContable"].Value.ToString();
                txtimportemes.Text = dataGridViewinforme.CurrentRow.Cells["ImpConcepto"].Value.ToString();
                idmensualidad = dataGridViewinforme.CurrentRow.Cells["MensualidadID"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        }
        
    }

