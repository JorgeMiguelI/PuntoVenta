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
    public partial class Actualizar_Prod : Form
    {
        private OracleConnection Ora;
        private bool verificaprecio = false;
        private bool verificaCantidad = false;
        public Actualizar_Prod()
        {
            InitializeComponent();
        }

        private void Actualizar_Prod_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt_producto.AutoCompleteCustomSource = Datos();
            txt_producto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_producto.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private AutoCompleteStringCollection Datos()
        {
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO; ");
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            String query = "SELECT NOMBRE FROM PRODUCTO";
            DataTable DT = Conectar(query);

            for(int i = 0; i < DT.Rows.Count; i++)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_producto.Text))
            {
                errorProvider1.SetError(txt_producto, "Ingrese el Nombre del Producto");
            }
            else
            {

                try
                {
                    errorProvider1.SetError(txt_producto, "");
                    String query = "SELECT *FROM PRODUCTO WHERE NOMBRE= " + "'" + txt_producto.Text + "'";
                    DataTable DT = Conectar(query);
                    txt_id.Text = DT.Rows[0]["ID_PRODUCTO"].ToString();
                    txt_nombre.Text = DT.Rows[0]["NOMBRE"].ToString();
                    txt_precio.Text = DT.Rows[0]["PRECIO"].ToString();
                    txt_exi.Text = DT.Rows[0]["EXISTENCIA"].ToString();

                    dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], DT.Rows[0]["EXISTENCIA"]);
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se ah Encontrado el producto");
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            verificaCantidad = false;
            verificaprecio = false;
            for(int i = 0; i < txt_precio.Text.Length; i++)
            {
                if (char.IsLetter(txt_precio.Text[i]))
                {
                    verificaprecio = true;
                    break;
                }
            }
            for(int j = 0; j < txt_exi.Text.Length; j++)
            {
                if (char.IsLetter(txt_exi.Text[j]))
                {
                    verificaCantidad = true;
                    break;
                }
            }

            if (verificaCantidad || verificaprecio || String.IsNullOrEmpty(txt_precio.Text) || String.IsNullOrEmpty(txt_exi.Text) || Convert.ToDouble(txt_precio.Text)<0 || Convert.ToDouble(txt_exi.Text) < 0 || txt_nombre.Text.Length>50)
            {
                if (txt_nombre.Text.Length > 50)
                {
                    errorProvider1.SetError(txt_nombre, "Se ah Exedido la longitud del nombre");
                    errorProvider1.SetError(txt_exi, "");
                    errorProvider1.SetError(txt_precio, "");
                }
                else
                {
                    if (verificaprecio || String.IsNullOrEmpty(txt_precio.Text) || Convert.ToDouble(txt_precio.Text) < 0)
                    {
                        errorProvider1.SetError(txt_precio, "Precio Invalido");
                        errorProvider1.SetError(txt_exi, "");
                        errorProvider1.SetError(txt_nombre, "");
                    }
                    else
                    {
                        errorProvider1.SetError(txt_exi, "Cantidad Invalida");
                        errorProvider1.SetError(txt_precio, "");
                        errorProvider1.SetError(txt_nombre, "");
                    }
                }
            }
            else
            {
                try
                {
                    errorProvider1.SetError(txt_precio, "");
                    errorProvider1.SetError(txt_exi, "");
                    errorProvider1.SetError(txt_nombre, "");
                    string query = "UPDATE PRODUCTO SET NOMBRE=" + "'" + txt_nombre.Text + "'"
                        + ", PRECIO=" + txt_precio.Text + ", EXISTENCIA=" + txt_exi.Text
                        + " WHERE ID_PRODUCTO=" + txt_id.Text;

                    DataTable DT = Conectar(query);
                    dataGridView1.Rows.Clear();
                    String query2 = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO=" + txt_id.Text;
                    DataTable DT2 = Conectar(query2);
                    dataGridView1.Rows.Add(DT2.Rows[0]["ID_PRODUCTO"], DT2.Rows[0]["NOMBRE"], DT2.Rows[0]["PRECIO"], DT2.Rows[0]["EXISTENCIA"]);

                    MessageBox.Show("Actualizacion Correcta");
                    txt_nombre.Text = "";
                    txt_exi.Text = "";
                    txt_id.Text = "";
                    txt_precio.Text = "";
                    txt_producto.Text = "";
                    txt_producto.Focus();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error no se Ah podido Actualizar");
                }
            }
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
