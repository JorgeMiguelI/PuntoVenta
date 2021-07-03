using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAbarrotes
{
    public partial class Productos_Surtir : Form
    {
        private OracleConnection Ora;
        public Productos_Surtir()
        {
            InitializeComponent();
        }

        private void EjecutarProc(string procedimiento)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = Ora;

            command.CommandText = procedimiento;
            command.CommandType = CommandType.StoredProcedure;

            Ora.Open();

            int exito = command.ExecuteNonQuery();
            if (exito == 1)
            {
                Ora.Close();
            }
        }

        private DataTable Conectar(String query)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand(query, Ora);
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable DT = new DataTable();
            adaptador.Fill(DT);
            Ora.Close();
            return DT;
        }

        private void Productos_Surtir_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");



            //Vacio la tabla
            try
            {
                String queryEl = "DELETE FROM PROD_EXI_BAJA";
                DataTable El = Conectar(queryEl);

            }
            catch(Exception error)
            {
                MessageBox.Show("Error al vaciar la tabla");
            }
            

            //Ejecuto mi Procedimiento;
            try
            {
                EjecutarProc("PRODS_EXISTENCIA_BAJA");

            }
            catch(Exception error)
            {
                MessageBox.Show("Error al ejecutar el Procedimiento");
            }

            //Una vez llenada la tabla con el procedure me traigo la informacion
            try
            {
                String query = "SELECT *FROM PROD_EXI_BAJA";
                DataTable DT = Conectar(query);

                for(int i = 0; i < DT.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(DT.Rows[i]["ID_PRODUCTO"], DT.Rows[i]["NOMBRE"], DT.Rows[i]["EXISTENCIA"]);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
