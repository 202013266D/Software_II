﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

public partial class MainWindow : Window
{
    string connectionString;
    List<Ruta> rutas;
    List<TipoCliente> tiposCliente;

    public MainWindow()
    {
        InitializeComponent();
        connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        CargarRutas();
        CargarTiposCliente();
    }

    private void RegistrarVenta_Click(object sender, RoutedEventArgs e)
    {
        //Ruta rutaSeleccionada = cmbRuta.SelectedItem as Ruta;
        /*TipoCliente tipoClienteSeleccionado = cmbTipoCliente.SelectedItem as TipoCliente;
        int cantidadPersonas;

        if (!int.TryParse(txtCantidadPersonas.Text, out cantidadPersonas))
        {
            MessageBox.Show("La cantidad de personas debe ser un número entero.");
            return;
        }

        if (rutaSeleccionada != null && tipoClienteSeleccionado != null)
        {
            RealizarVenta(rutaSeleccionada.RutaID, cantidadPersonas, tipoClienteSeleccionado.TipoID);
        }
        else
        {
            MessageBox.Show("Por favor, seleccione una ruta y un tipo de cliente antes de registrar la venta.");
        }*/
    }
       

    private void CargarRutas()
    {
        rutas = new List<Ruta>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT RutaID, Nombre FROM Rutas";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int rutaID = (int)reader["RutaID"];
                string nombre = (string)reader["Nombre"];
                rutas.Add(new Ruta { RutaID = rutaID, Nombre = nombre });
            }
        }
        cmbRuta.ItemsSource = rutas;
        cmbRuta.DisplayMemberPath = "Nombre";
    }

    private void CargarTiposCliente()
    {
        tiposCliente = new List<TipoCliente>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT TipoID, Tipo FROM TiposCliente";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int tipoID = (int)reader["TipoID"];
                string tipo = (string)reader["Tipo"];
                tiposCliente.Add(new TipoCliente { TipoID = tipoID, Tipo = tipo });
            }
        }
        cmbTipoCliente.ItemsSource = tiposCliente;
        cmbTipoCliente.DisplayMemberPath = "Tipo";
    }

    private void ActualizarDataGrid()
    {
        // Limpiar el DataGrid
        dgVentas.Items.Clear();

        // Cargar las ventas desde la base de datos y agregarlas al DataGrid
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Ventas.RutaID, Ventas.CantidadPersonas, Ventas.TipoClienteID, Rutas.Nombre AS NombreRuta, TiposCliente.Tipo AS TipoCliente " +
                           "FROM Ventas " +
                           "JOIN Rutas ON Ventas.RutaID = Rutas.RutaID " +
                           "JOIN TiposCliente ON Ventas.TipoClienteID = TiposCliente.TipoID";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int rutaID = (int)reader["RutaID"];
                int cantidadPersonas = (int)reader["CantidadPersonas"];
                int tipoClienteID = (int)reader["TipoClienteID"];
                string nombreRuta = (string)reader["NombreRuta"];
                string tipoCliente = (string)reader["TipoCliente"];

                dgVentas.Items.Add(new VentaItem
                {
                    Ruta = nombreRuta,
                    CantidadPersonas = cantidadPersonas,
                    TipoCliente = tipoCliente
                });
            }
        }
    }
}

public class Ruta
{
    public int RutaID { get; set; }
    public string Nombre { get; set; }
}

public class TipoCliente
{
    public int TipoID { get; set; }
    public string Tipo { get; set; }
}

public class VentaItem
{
    public string Ruta { get; set; }
    public int CantidadPersonas { get; set; }
    public string TipoCliente { get; set; }
}
