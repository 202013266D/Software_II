using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;



public partial class MainWindow : Window
{
    string connectionString;

    public MainWindow()
    {
        InitializeComponent();
        connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        CargarRutas();
        CargarTiposCliente();
        ActualizarDataGrid();
    }

    private void RegistrarVenta_Click(object sender, RoutedEventArgs e)
    {
        Ruta rutaSeleccionada = cmbRuta.SelectedItem as Ruta;
        TipoCliente tipoClienteSeleccionado = cmbTipoCliente.SelectedItem as TipoCliente;
        int cantidadPersonas;


        if (!int.TryParse(txtCantidadPersonas.Text, out cantidadPersonas) || cantidadPersonas <= 0)
        {
            MessageBox.Show("Por favor, ingrese una cantidad válida de personas.");
            return;
        }

        if (rutaSeleccionada != null && tipoClienteSeleccionado != null)
        {

            RealizarVenta(rutaSeleccionada.RutaID, cantidadPersonas, tipoClienteSeleccionado.TipoID);
            LimpiarCampos();
            ActualizarDataGrid();
        }
        else
        {
            MessageBox.Show("Por favor, seleccione una ruta y un tipo de cliente antes de registrar la venta.");
        }
    }

    private void RealizarVenta(int rutaID, int cantidadPersonas, int tipoClienteID)
    {

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // se esta llamando al procedmiento almacenado
            SqlCommand command = new SqlCommand("RegistrarVenta", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RutaID", rutaID);
            command.Parameters.AddWithValue("@CantidadPersonas", cantidadPersonas);
            command.Parameters.AddWithValue("@TipoClienteID", tipoClienteID);

            connection.Open();
            command.ExecuteNonQuery();
        }

        MessageBox.Show("Venta registrada.");
    }

    private void LimpiarCampos()
    {
        cmbRuta.SelectedItem = null;
        cmbTipoCliente.SelectedItem = null;
        txtCantidadPersonas.Clear();
    }

    private void CargarRutas()
    {
        List<Ruta> rutas = new List<Ruta>();
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
        List<TipoCliente> tiposCliente = new List<TipoCliente>();
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
        List<VentaItem> ventas = new List<VentaItem>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Ventas.RutaID, Ventas.CantidadPersonas, Ventas.TipoClienteID, Ventas.Precio, Rutas.Nombre AS NombreRuta, TiposCliente.Tipo AS TipoCliente " +
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
                decimal precio = (decimal)reader["Precio"];
                string nombreRuta = (string)reader["NombreRuta"];
                string tipoCliente = (string)reader["TipoCliente"];

                ventas.Add(new VentaItem
                {
                    Ruta = nombreRuta,
                    CantidadPersonas = cantidadPersonas,
                    TipoCliente = tipoCliente,
                    Precio = precio
                });
            }
        }

        dgVentas.ItemsSource = ventas;
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
    public decimal Precio { get; set; }
}

