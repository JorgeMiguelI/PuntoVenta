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
    public partial class AltasProductos : Form
    {
        private OracleConnection Ora;
        private String tipoProd;
        private bool verificaprecio = false;
        private bool verificatipo = false;
        private bool verificaexistencia = false;
        private bool verificaNombre = false;
        public AltasProductos()
        {
            InitializeComponent();
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

        private void AltasProductos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT ID_PRODUCTO FROM PRODUCTO";
            DataTable DT = Conectar(query);
            int idProducto;
            if (DT.Rows.Count > 0)
            {
                int pos = DT.Rows.Count;
                idProducto = Convert.ToInt32(DT.Rows[pos - 1]["ID_PRODUCTO"].ToString()) + 1;
            }
            else
            {
                idProducto = 1;
            }

            verificaexistencia = false;
            verificaNombre = false;
            verificaprecio = false;
            verificatipo = false;

            // Verificamos que la longitud del nombre no sea mayor a la admitida por la base de datos
            if(txt_nombre.Text.Length > 50)
            {
                verificaNombre = true;
            }

            //Verificamos que el valor de la existencia no sea una letra
            for(int i = 0; i < txt_Existencia.Text.Length; i++)
            {
                if (char.IsLetter(txt_Existencia.Text[i]))
                {
                    verificaexistencia = true;
                    break;
                }
            }

            //Verificamos que el precio no contenga letras
            for(int i = 0; i < txt_precio.Text.Length; i++)
            {
                if (char.IsLetter(txt_precio.Text[i]))
                {
                    verificaprecio = true;
                    break;
                }
            }

            //Verificamos el tipo del producto
            if(!tipoProd.Equals("perecedero") && !tipoProd.Equals("abarrote"))
            {
                verificatipo = true;
            }

            if(verificaNombre || String.IsNullOrEmpty(txt_nombre.Text) || verificaexistencia || String.IsNullOrEmpty(txt_Existencia.Text) || Convert.ToInt32(txt_Existencia.Text)<=0 || verificaprecio || String.IsNullOrEmpty(txt_precio.Text) || Convert.ToDouble(txt_precio.Text)<=0.0 || verificatipo)
            {
                if(verificaNombre || String.IsNullOrEmpty(txt_nombre.Text))
                {
                    errorProvider1.SetError(txt_nombre, "Nombre no valido");
                    errorProvider1.SetError(comboBox1, "");
                    errorProvider1.SetError(txt_precio, "");
                    errorProvider1.SetError(txt_Existencia, "");
                }
                else
                {
                    if(verificaexistencia || String.IsNullOrEmpty(txt_Existencia.Text) || Convert.ToInt32(txt_Existencia.Text) <= 0)
                    {
                        errorProvider1.SetError(txt_Existencia, "Valor de Existencia no valido");
                        errorProvider1.SetError(txt_nombre, "");
                        errorProvider1.SetError(comboBox1, "");
                        errorProvider1.SetError(txt_precio, "");
                    }
                    else
                    {
                        if(verificaprecio || String.IsNullOrEmpty(txt_precio.Text) || Convert.ToDouble(txt_precio.Text) <= 0.0)
                        {
                            errorProvider1.SetError(txt_precio, "Valor de Precio no valido");
                            errorProvider1.SetError(txt_Existencia, "");
                            errorProvider1.SetError(txt_nombre, "");
                            errorProvider1.SetError(comboBox1, "");
                        }
                        else
                        {
                            if (verificatipo)
                            {
                                errorProvider1.SetError(comboBox1, "Tipo de producto no valido");
                                errorProvider1.SetError(txt_precio, "");
                                errorProvider1.SetError(txt_Existencia, "");
                                errorProvider1.SetError(txt_nombre, "");
                            }
                        }
                    }
                }
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
                errorProvider1.SetError(txt_precio, "");
                errorProvider1.SetError(txt_Existencia, "");
                errorProvider1.SetError(txt_nombre, "");
                try
                {
                    String query2 = "INSERT INTO PRODUCTO VALUES(" + idProducto + ", '" + txt_nombre.Text + "', " + txt_precio.Text + ", '" + tipoProd + "', " + txt_Existencia.Text + " )";
                    DataTable insert = Conectar(query2);

                    MessageBox.Show("Producto Guardado");

                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_Existencia.Text = "";
                    comboBox1.Text = "";

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar el Producto");
                }

            }


            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoProd = comboBox1.SelectedItem.ToString();
        }
    }
}
