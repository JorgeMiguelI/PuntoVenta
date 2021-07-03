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
    public partial class Compras : Form
    {
        private OracleConnection Ora;
        private int idCompra;
        private String Proveedor;
        private int idProducto;

        public Compras()
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

        private void Compras_Load(object sender, EventArgs e)
        {
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");

            txt_nombrePro.AutoCompleteCustomSource = Datos();
            txt_nombrePro.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_nombrePro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string query = "SELECT NOMBRE FROM PROVEEDOR ";
            DataTable DT = Conectar(query);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                comboBox1.Items.Add(DT.Rows[i]["NOMBRE"].ToString());
            }

           

        }

        private AutoCompleteStringCollection Datos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            String query = "SELECT NOMBRE FROM PRODUCTO";
            DataTable DT = Conectar(query);

            for(int i = 0; i < DT.Rows.Count; i++)
            {
                datos.Add(DT.Rows[i]["NOMBRE"].ToString());
            }

            return datos;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registroCompra_Click(object sender, EventArgs e)
        {
            try
            {
                String query1 = "SELECT ID_PROVEEDOR FROM PROVEEDOR WHERE NOMBRE= '" + this.Proveedor + "'";
                DataTable prov = Conectar(query1);
                int idProv = Convert.ToInt32(prov.Rows[0]["ID_PROVEEDOR"]);

                String query = "SELECT ID_COMPRA FROM COMPRA";
                DataTable DT = Conectar(query);

                if (DT.Rows.Count > 0)
                {
                    int pos = DT.Rows.Count;
                    idCompra = Convert.ToInt16(DT.Rows[pos - 1]["ID_COMPRA"].ToString()) + 1;
                }
                else
                {
                    idCompra = 1;
                }
                try
                {
                    String query2 = "INSERT INTO COMPRA VALUES(" + idCompra + ", " + 0 + ", SYSDATE, " + idProv + ")";
                    DataTable insert = Conectar(query2);

                    groupBox_datos.Enabled = true;
                    groupBox2.Enabled = false;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Registrar la Compra");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("No se encontro el Proveedor");
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Proveedor = comboBox1.SelectedItem.ToString();
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            bool verificaNombre = false;
            bool verificaPrecio = false;
            bool verificaCompras = false;
            String querynombres = "SELECT NOMBRE FROM PRODUCTO";
            DataTable nombresPro = Conectar(querynombres);
            for(int i = 0; i < nombresPro.Rows.Count; i++)
            {
                if (txt_nombrePro.Text.Equals(nombresPro.Rows[i]["NOMBRE"]))
                {
                    verificaNombre = true;
                    break;
                }
            }
            for(int j = 0; j < txt_precioCompra.Text.Length; j++)
            {
                if (char.IsLetter(txt_precioCompra.Text[j]))
                {
                    verificaPrecio = true;
                    break;
                }
            }
            for(int k = 0; k < txt_Compras.Text.Length; k++)
            {
                if (char.IsLetter(txt_Compras.Text[k]))
                {
                    verificaCompras = true;
                    break;
                }
            }

            if (verificaNombre == false || String.IsNullOrEmpty(txt_nombrePro.Text))
            {
                if (String.IsNullOrEmpty(txt_nombrePro.Text))
                {
                    errorProvider1.SetError(txt_nombrePro, "Ingrese el nombre del producto");
                    errorProvider1.SetError(txt_Compras, "");
                    errorProvider1.SetError(txt_precioCompra, "");
                }
                else
                {
                    errorProvider1.SetError(txt_nombrePro, "Este producto no esta Registrado, Ve a Registralo");
                    errorProvider1.SetError(txt_Compras, "");
                    errorProvider1.SetError(txt_precioCompra, "");
                }


            }
            else
            {
                if(verificaPrecio || String.IsNullOrEmpty(txt_precioCompra.Text) || Convert.ToDouble(txt_precioCompra.Text)<=0 )
                {
                    errorProvider1.SetError(txt_precioCompra, "Precio no valido");
                    errorProvider1.SetError(txt_nombrePro, "");
                    errorProvider1.SetError(txt_Compras, "");
                }
                else
                {
                    if(verificaCompras || String.IsNullOrEmpty(txt_Compras.Text) || Convert.ToInt32(txt_Compras.Text)<0)
                    {
                        errorProvider1.SetError(txt_Compras, " Total de Compras Invalido");
                        errorProvider1.SetError(txt_nombrePro, "");
                        errorProvider1.SetError(txt_precioCompra, "");
                    }
                    else
                    {
                        errorProvider1.SetError(txt_precioCompra, "");
                        errorProvider1.SetError(txt_nombrePro, "");
                        errorProvider1.SetError(txt_Compras, "");

                        //Codigo para Registrar la Compra


                        try
                        {
                            String query = "SELECT ID_PRODUCTO FROM PRODUCTO WHERE NOMBRE= '" + txt_nombrePro.Text + "'";
                            DataTable DT = Conectar(query);
                            idProducto = Convert.ToInt32(DT.Rows[0]["ID_PRODUCTO"]);


                            String query2 = "INSERT INTO COMPRA_PRODUCTO VALUES(" + idCompra + ", " + idProducto + ", " + txt_Compras.Text + ", " + txt_precioCompra.Text + ")";
                            DataTable insert = Conectar(query2);
                        }
                        catch (Exception error)
                        {
                            Ora.Close();
                            MessageBox.Show("Error al Insertar la Compra " + error.Message);
                        }

                        

                        //Modificamos el monto de la compra
                        try
                        {
                            String query3 = "SELECT COSTO_COMPRA FROM COMPRA WHERE ID_COMPRA=" + idCompra;
                            DataTable Costos = Conectar(query3);
                            double montoCompra = Convert.ToDouble(txt_precioCompra.Text) * Convert.ToDouble(txt_Compras.Text);
                            double totalCompra = Convert.ToDouble(Costos.Rows[0]["COSTO_COMPRA"]) + montoCompra;

                            String query4 = "UPDATE COMPRA SET COSTO_COMPRA=" + totalCompra + " WHERE ID_COMPRA=" + idCompra;
                            DataTable actualiza = Conectar(query4);

                            txt_nombrePro.Text = "";
                            txt_Compras.Text = "";
                            txt_precioCompra.Text = "";
                            MessageBox.Show("Compra registrada");
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error, No se pudo actualizar el monto de la compra");
                        }



                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox_datos.Enabled = false;
        }
    }
}
