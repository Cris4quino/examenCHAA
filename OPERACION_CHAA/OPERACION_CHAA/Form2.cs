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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btDeposito_Click(object sender, EventArgs e)
        {
            String cadenadeconexion = @"Data Source=DESKTOP-5K63K2M;Initial Catalog=BD_TRANSACCIONES_CHAA;User ID=cristian;Password=123examen";
            try
            {

                DataTable dtResult = new DataTable();
                SqlConnection conexion = new SqlConnection(cadenadeconexion);
                SqlCommand comando = new SqlCommand("sp_creacion_movimiento", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_CUENTA", 0);
                comando.Parameters.AddWithValue("@NRO_CUENTA", txtCuenta.Text.Trim());
               
                comando.Parameters.AddWithValue("@TIPO", "A");
                comando.Parameters.AddWithValue("@IMPORTE", Convert.ToDecimal(txtMonto.Text.Trim()));

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();


                //actualiza saldo
                DataTable dtResultS = new DataTable();
                SqlConnection conexionS = new SqlConnection(cadenadeconexion);
                SqlCommand comandoS = new SqlCommand("actualiza_saldo", conexionS);

                comandoS.CommandType = CommandType.StoredProcedure;


                comandoS.Parameters.AddWithValue("@NRO_CUENTA", txtCuenta.Text.Trim());

                comandoS.Parameters.AddWithValue("@SALDO", txtMonto.Text.Trim());
                comandoS.Parameters.AddWithValue("@TIPO", "A");
                conexionS.Open();
                comandoS.ExecuteNonQuery();
                conexionS.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR"+ex);
            }
        }

        private void btRetiro_Click(object sender, EventArgs e)
        {
            String cadenadeconexion = @"Data Source=DESKTOP-5K63K2M;Initial Catalog=BD_TRANSACCIONES_CHAA;User ID=cristian;Password=123examen";
            try
            {

                DataTable dtResult = new DataTable();
                SqlConnection conexion = new SqlConnection(cadenadeconexion);
                SqlCommand comando = new SqlCommand("sp_creacion_movimiento", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_CUENTA", 0);
                comando.Parameters.AddWithValue("@NRO_CUENTA", txtCuenta.Text.Trim());

                comando.Parameters.AddWithValue("@TIPO", "D");
                comando.Parameters.AddWithValue("@IMPORTE", txtMonto.Text.Trim());

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();


                //actualiza saldo
                DataTable dtResultS = new DataTable();
                SqlConnection conexionS = new SqlConnection(cadenadeconexion);
                SqlCommand comandoS = new SqlCommand("actualiza_saldo", conexionS);

                comandoS.CommandType = CommandType.StoredProcedure;

                
                comandoS.Parameters.AddWithValue("@NRO_CUENTA", txtCuenta.Text.Trim());

                comandoS.Parameters.AddWithValue("@SALDO", txtMonto.Text.Trim());
                comandoS.Parameters.AddWithValue("@TIPO", "D");
                conexionS.Open();
                comandoS.ExecuteNonQuery();
                conexionS.Close();




            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex);
            }
        }
    }
}
