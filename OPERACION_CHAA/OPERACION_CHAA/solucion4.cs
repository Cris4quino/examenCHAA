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
    public partial class solucion4 : Form
    {
        public solucion4()
        {
            InitializeComponent();
        }

        private void solucion4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_TRANSACCIONES_CHAADataSet.CUENTA' Puede moverla o quitarla según sea necesario.
            this.cUENTATableAdapter.Fill(this.bD_TRANSACCIONES_CHAADataSet.CUENTA);
            String cadenadeconexion = @"Data Source=DESKTOP-5K63K2M;Initial Catalog=BD_TRANSACCIONES_CHAA;User ID=cristian;Password=123examen";


            try
            {
                // donde se almacenara la respuesta
                DataTable dtResult = new DataTable();
                // donde se realizal la conexion con la cadena string
                SqlConnection con = new SqlConnection(cadenadeconexion);
                // por que se conectara o que adaptador SP o consulta 
                SqlDataAdapter comando = new SqlDataAdapter("sp_trae_cuenta", con);
                // el tipo de conecccion a la base de datos 
                comando.SelectCommand.CommandType = CommandType.StoredProcedure;
                // comando.SelectCommand.CommandTimeout = 36000;

                con.Open();
                comando.Fill(dtResult);
                con.Close();


                //LLena al datagridview
                dtTodo.DataSource = dtResult;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
