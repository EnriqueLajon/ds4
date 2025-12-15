using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {

        String connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("Conectado a SQL Server");

                    // Ejecutar el query
                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader lector = comando.ExecuteReader();

                    // Limpiar listbox antes de agregar
                    listBox1.Items.Clear();

                    // Leer los nombres y agregarlos al listbox
                    while (lector.Read())
                    {
                        listBox1.Items.Add(lector["ProductName"].ToString());
                    }

                    lector.Close();
                    conexion.Close();
                    MessageBox.Show("Productos listados correctamente");
                }
                else
                {
                    conexion.Close();
                    MessageBox.Show("Desconectado de SQL Server");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                {
                    MessageBox.Show("error" + ex.Message);
                }
            }
            
            }
            
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
