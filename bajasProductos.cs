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
    public partial class bajasProductos : Form
    {
        private OracleConnection Ora;
        public bajasProductos()
        {
            InitializeComponent();
        }

        private void EjecutarProc(string procedimiento, String prod)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = Ora;

            command.CommandText = procedimiento;
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter();
            param1.OracleType = OracleType.VarChar;
            param1.Direction = ParameterDirection.InputOutput;
            param1.ParameterName = "NOMBREPROD";
            param1.Value = prod;

            command.Parameters.Add(param1);
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

        private void bajasProductos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");

            txt_buscar.AutoCompleteCustomSource = BuscarDatos();
            txt_buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private AutoCompleteStringCollection BuscarDatos()
        {
            AutoCompleteStringCollection Productos = new AutoCompleteStringCollection();
            String query = "SELECT NOMBRE FROM PRODUCTO";
            DataTable DT = Conectar(query);

            for(int i = 0; i < DT.Rows.Count; i++)
            {
                Productos.Add(DT.Rows[i]["NOMBRE"].ToString());
            }
            return Productos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT * FROM PRODUCTO WHERE NOMBRE= '" + txt_buscar.Text + "'";
                DataTable DT = Conectar(query);

                txt_nombre.Text = DT.Rows[0]["NOMBRE"].ToString();
                txt_precio.Text = DT.Rows[0]["PRECIO"].ToString();
                txt_tipo.Text = DT.Rows[0]["TIPO"].ToString();
                txt_Existencia.Text = DT.Rows[0]["EXISTENCIA"].ToString();
            }catch(Exception error)
            {
                MessageBox.Show("Producto no Encontrado");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                String queryDel = "SELECT ID_PRODUCTO FROM PRODUCTO WHERE NOMBRE= '" + txt_buscar.Text + "'";
                DataTable prod = Conectar(queryDel);
                int prodId = Convert.ToInt32(prod.Rows[0]["ID_PRODUCTO"]);

                String queryEl1 = "DELETE FROM PRODUCTO_VENTA WHERE ID_PRODUCTO=" + prodId;
                DataTable El1 = Conectar(queryEl1);

                String queryEl2 = "DELETE FROM COMPRA_PRODUCTO WHERE ID_PRODUCTO=" + prodId;
                DataTable El2 = Conectar(queryEl2);


                EjecutarProc("ELIMINAPROD", txt_buscar.Text);

                MessageBox.Show("Producto eliminado Correctamente");
                txt_buscar.Text = "";
                txt_Existencia.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_tipo.Text = "";
            }catch(Exception error)
            {
                MessageBox.Show("Error no se ah podido eliminar este Producto: "+ error.Message);
            }
        }
    }
}
