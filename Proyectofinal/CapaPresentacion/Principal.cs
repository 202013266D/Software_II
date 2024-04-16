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
using System.Web;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void linkregistroalumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registroalumno = new Registroalumno();
            registroalumno.Show();
            this.Hide();
        }
             

        private void linkinformeeconomico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form informe = new informeeconomico();
            informe.Show();
            this.Hide();
        }

        private void linkcerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetenerAplicacion();
        }

        private void DetenerAplicacion()
        {
            
            Application.Exit();
        }

    }
}
