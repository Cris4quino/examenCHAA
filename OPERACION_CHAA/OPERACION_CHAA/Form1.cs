using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPERACION_CHAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            String cadenaConexion = @"Data Source=DESKTOP-5K63K2M;Initial Catalog=BD_TRANSACCIONES_CHAA;User ID=cristian;Password=123examen";
            try
            {
        
                String moneda="";
                String tipo="";

                if (cbMoneda.SelectedIndex==0)
                {
                    moneda="BOL";
                }
                if (cbMoneda.SelectedIndex == 1)
                {
                    moneda = "USD";
                }
                if (rbAhorros.Checked)
                {
                    tipo = "AHO";
                }
                if (rbCorriente.Checked)
                {
                    tipo = "CTE";
                }


                DataTable dtResult = new DataTable();
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand("sp_creacion_cuenta", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NRO_CUENTA", txtNroCuenta.Text.Trim());
                comando.Parameters.AddWithValue("@TIPO", tipo.Trim());
                comando.Parameters.AddWithValue("@MONEDA", moneda.Trim());
                comando.Parameters.AddWithValue("@NOMBRE", txtNombre.Text.Trim());
                comando.Parameters.AddWithValue("@SALDO", 0);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }
    }
}
