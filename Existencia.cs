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
    public partial class Existencia : Form
    {
        public OracleConnection Ora;
        public Existencia()
        {
            InitializeComponent();
        }

        private void Existencia_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO; ");
            String query = "SELECT *FROM PRODS";
            DataTable DT = Conectar(query);
            for(int i=0;i< DT.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(DT.Rows[i]["ID_PRODUCTO"], DT.Rows[i]["NOMBRE"], DT.Rows[i]["PRECIO"], DT.Rows[i]["EXISTENCIA"]);
            }

            txt_producto.AutoCompleteCustomSource = Datos();
            txt_producto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_producto.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private AutoCompleteStringCollection Datos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            String query = "SELECT NOMBRE FROM PRODUCTO";
            DataTable DT = Conectar(query);

            for(int i=0; i< DT.Rows.Count; i++)
            {
                datos.Add(DT.Rows[i]["NOMBRE"].ToString());
            }

            return datos;


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_producto.Text))
            {
                errorProvider1.SetError(txt_producto, "Ingrese el Nombre del producto");
            }
            else
            {

                try
                {
                    errorProvider1.SetError(txt_producto, "");
                    String query = "SELECT *FROM PRODUCTO WHERE NOMBRE = " + "'" + txt_producto.Text + "'";
                    DataTable DT = Conectar(query);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], DT.Rows[0]["EXISTENCIA"]);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Producto no Encontrado ");
                    txt_producto.Text = "";
                }

            }

        }
    }
}
