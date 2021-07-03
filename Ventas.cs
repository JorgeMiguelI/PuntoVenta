using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Collections;

namespace TiendaAbarrotes
{
    public partial class Ventas : Form
    {

        public OracleConnection Conn;
        public static int ContFilas = 0;
        public static double total;
        private double precioProd;
        private bool validaCampoCntidad= false;
        private bool validanombrePro = false;
        private String nombrePro;
        private ArrayList listaProductos = new ArrayList();
       
        public Ventas()
        {
            InitializeComponent();
        }

        public DataTable Conectar(string query)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand(query, Conn);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable DT = new DataTable();
            adaptador.Fill(DT);
            Conn.Close();
            return DT;
        }



        private void Ventas_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Conn = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");
            txtCodigo.Focus();

            string query = "SELECT NOMBRE FROM PRODUCTO WHERE TIPO= 'perecedero'";
            DataTable DT = Conectar(query);


            for(int i=0; i<DT.Rows.Count; i++)
            {
                comboBox1.Items.Add(DT.Rows[i]["NOMBRE"].ToString());
            }

            comboBox1.AutoCompleteCustomSource = DatosProd();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            /*txtCantidad.AutoCompleteCustomSource = ObtenerDatos();
            txtCantidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCantidad.AutoCompleteSource = AutoCompleteSource.CustomSource;*/

         


        }

        private AutoCompleteStringCollection DatosProd()
        {
            string query = "SELECT NOMBRE FROM PRODUCTO WHERE TIPO= 'perecedero' ";
            DataTable DT = Conectar(query);
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
               datos.Add(DT.Rows[i]["NOMBRE"].ToString());
            }

            return datos;
        }

        private AutoCompleteStringCollection ObtenerDatos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            double valormin = 0;
            for( int i=0; i < 120;i++)
            {
                datos.Add((valormin += 0.25).ToString());
                
            }

            return datos;
        }

        private void GuardaProducto()
        {
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnColocar_Click(object sender, EventArgs e)
        {

        }

        private void BtnColocar_Click_1(object sender, EventArgs e)
        {
            GuardaProducto();
        }

        private void BtnCambio_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPago.Text)== true)
            {
                errorProvider1.SetError(txtPago, "Ingrese El Pago");
            }
            else
            {
                if (Convert.ToDouble(txtPago.Text) < Convert.ToDouble(lbltotalPago.Text))
                {
                    errorProvider1.SetError(txtPago, "El Pago No es Suficiente Para Realizar La Compra");
                    txtPago.Text = "";
                }
                else
                {
                    errorProvider1.SetError(txtPago, "");
                    double cambio = Convert.ToDouble(txtPago.Text) - Convert.ToDouble(lbltotalPago.Text);
                    lblCambio.Text = "$" + cambio.ToString();
                }
            }
        }

        private void Nuevo()
        {
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtPago, "");
            errorProvider1.SetError(txtPrecio, "");
            dataGridView1.Rows.Clear();
            txtCodigo.Text = "";
            lbltotalPago.Text = "";
            lblCambio.Text = "";
            txtPago.Text = "";
            ContFilas = 0;
            radioButton1.Checked = false;
            radioContado.Checked = false;
        }

        private void BtnNnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
           
            if (dataGridView1.Rows.Count > 0)
            {   
                try
                {
                    ((productoCantidad)listaProductos[dataGridView1.CurrentRow.Index]).cantidad = ((productoCantidad)listaProductos[dataGridView1.CurrentRow.Index]).cantidad - 1;
                    total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value));
                    lbltotalPago.Text = total.ToString();
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value) - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value));
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = ((productoCantidad)listaProductos[dataGridView1.CurrentRow.Index]).cantidad;
                    if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value) < 1 )
                    {
                        listaProductos.RemoveAt(dataGridView1.CurrentRow.Index);
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        ContFilas--;
                    }

                    txtPago.Text = "";
                    lblCambio.Text = "";

                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("No ah Seleccionado producto a eliminar " + error.Message);
                }

            }
            else
            {
                MessageBox.Show("No ah nada que Borrar");
            }
        }

        private void TxtcolocaPro_Click(object sender, EventArgs e)
        {
            validaCampoCntidad = false;
            for(int i = 0; i < txtCantidad.Text.Length; i++)
            {
                if (char.IsLetter(txtCantidad.Text[i]) )
                {
                    validaCampoCntidad = true;
                    break;
                }
            }

            if (String.IsNullOrEmpty(txtCantidad.Text))
            {
                validaCampoCntidad = true;
            }

            if (string.IsNullOrEmpty(comboBox1.Text) == true || validaCampoCntidad == true || Convert.ToDouble(txtCantidad.Text)<=0.0)
            {
                if (string.IsNullOrEmpty(comboBox1.Text) == true)
                {
                    errorProvider1.SetError(comboBox1, "Ingrese el Nombre del Producto");
                    errorProvider1.SetError(txtCantidad, "");
                }
                else
                {
                     
                    errorProvider1.SetError(comboBox1, "");
                    errorProvider1.SetError(txtCantidad, "Cantidad Invalida");
                    
                   
                }
                
            }
            else
            {
                try
                {
                    errorProvider1.SetError(comboBox1, "");
                    errorProvider1.SetError(txtCantidad, "");
                    if (string.IsNullOrEmpty(txtPrecio.Text) == true)
                    {
                        errorProvider1.SetError(txtPrecio, "Ingrese el Costo del Producto");
                    }
                    else
                    {
                        errorProvider1.SetError(comboBox1, "");
                        errorProvider1.SetError(txtPrecio, "");

                        //Metodo Para Meter Productos a la Tabla


                        bool existe = false;
                        int numFila = 0;
                        DataTable DT = new DataTable();
                        try
                        {

                            string query = "SELECT * FROM PRODUCTO WHERE NOMBRE= " + nombrePro;
                            DT = Conectar(query);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: " + error.Message);
                        }


                        if (ContFilas == 0)
                        {

                            dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], txtCantidad.Text);

                            double importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                            dataGridView1.Rows[ContFilas].Cells[4].Value = importe;
                            listaProductos.Add(new productoCantidad(Convert.ToInt32(DT.Rows[0]["ID_PRODUCTO"]), Convert.ToDouble(txtCantidad.Text)));
                            ContFilas++;
                        }
                        else
                        {
                            foreach (DataGridViewRow Fila in dataGridView1.Rows)
                            {
                                if (Fila.Cells[0].Value.ToString() == DT.Rows[0]["ID_PRODUCTO"].ToString())
                                {
                                    existe = true;
                                    numFila = Fila.Index;
                                }
                            }

                            if (existe == true)
                            {
                                dataGridView1.Rows[numFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value)).ToString();
                                double importe = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);
                                dataGridView1.Rows[numFila].Cells[4].Value = importe;
                                ((productoCantidad)listaProductos[numFila]).cantidad = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                            }
                            else
                            {
                                dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], txtCantidad.Text);
                                double importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                                dataGridView1.Rows[ContFilas].Cells[4].Value = importe;
                                listaProductos.Add(new productoCantidad(Convert.ToInt32(DT.Rows[0]["ID_PRODUCTO"]), Convert.ToDouble(txtCantidad.Text)));
                                ContFilas++;
                            }

                        }

                        total = 0;
                        foreach (DataGridViewRow rows in dataGridView1.Rows)
                        {
                            total += Convert.ToDouble(rows.Cells[4].Value);
                        }
                        lbltotalPago.Text = total.ToString();




                        txtCodigo.Text = "";
                        comboBox1.Text = "";
                        txtPrecio.Text = "";
                        txtCantidad.Text = "";

                        //



                    }

                }
                catch(Exception error)
                {
                    MessageBox.Show("la Cantidad no es la Correcta");
                }
                
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            errorProvider1.SetError(txtCodigo, "");
            nombrePro= "'"+comboBox1.SelectedItem.ToString()+ "'";
            string query = "SELECT PRECIO FROM PRODUCTO WHERE NOMBRE =" + nombrePro;
            DataTable DT = Conectar(query);
            precioProd = Convert.ToDouble(DT.Rows[0]["PRECIO"].ToString());
            txtPrecio.Text = precioProd.ToString();
            
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_AcceptsTabChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            validanombrePro = false;
            for (int i = 0; i < txtCodigo.Text.Length; i++)
            {
                if (char.IsLetter(txtCodigo.Text[i]))
                {
                    validanombrePro = true;
                    break;
                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) == true || validanombrePro == true)
                {

                    if (string.IsNullOrEmpty(txtCodigo.Text) == true)
                    {
                        errorProvider1.SetError(txtCodigo, "Ingrese el Codigo del Producto");
                    }
                    else
                    {
                        errorProvider1.SetError(txtCodigo, "Codigo de Producto Invalido");
                    }
                    
                }
                else
                {
                    errorProvider1.SetError(txtCodigo, "");
                    try
                    {
                        bool existe = false;
                        int numFila = 0;
                        string query = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO= " + txtCodigo.Text;
                        DataTable DT = Conectar(query);
                        //listaProductos.Add(DT.Rows[0]["ID_PRODUCTO"].ToString());
                        if (ContFilas == 0)
                        {
                            listaProductos.Add(new productoCantidad(Convert.ToInt32(DT.Rows[0]["ID_PRODUCTO"]), 1));
                            dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], 1);
                            double importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                            dataGridView1.Rows[ContFilas].Cells[4].Value = importe;

                            ContFilas++;
                        }
                        else
                        {
                            foreach (DataGridViewRow Fila in dataGridView1.Rows)
                            {
                                if (Fila.Cells[0].Value.ToString() == txtCodigo.Text)
                                {
                                    existe = true;
                                    numFila = Fila.Index;
                                }
                            }

                            if (existe == true)
                            {
                                dataGridView1.Rows[numFila].Cells[3].Value = (1 + Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value)).ToString();
                                double importe = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);
                                dataGridView1.Rows[numFila].Cells[4].Value = importe;
                                ((productoCantidad)listaProductos[numFila]).cantidad = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                            }
                            else
                            {
                                dataGridView1.Rows.Add(DT.Rows[0]["ID_PRODUCTO"], DT.Rows[0]["NOMBRE"], DT.Rows[0]["PRECIO"], 1);
                                double importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                                dataGridView1.Rows[ContFilas].Cells[4].Value = importe;
                                listaProductos.Add(new productoCantidad(Convert.ToInt32(DT.Rows[0]["ID_PRODUCTO"]), 1));
                                ContFilas++;
                            }

                        }

                        total = 0;
                        foreach (DataGridViewRow rows in dataGridView1.Rows)
                        {
                            total += Convert.ToDouble(rows.Cells[4].Value);
                        }
                        lbltotalPago.Text = total.ToString();

                        

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("No se ah encontrado el codigo de producto Especificado");
                    }
                    txtCodigo.Text = "";
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

            
            int id = 0;
            try
            {

                String query1 = "SELECT ID_VENTA FROM VENTA";
                DataTable ventas = Conectar(query1);
                if (ventas.Rows.Count > 0)
                {
                    int pos = ventas.Rows.Count;
                    id = Convert.ToInt16(ventas.Rows[pos - 1]["ID_VENTA"].ToString()) + 1;
                }
                else
                {
                    id = 1;
                }
                //Llena Tabla Ventas
                String query = "INSERT INTO VENTA(ID_VENTA, FECHA, MONTO) VALUES(" + id + ", SYSDATE" + "," + lbltotalPago.Text + ")";
                DataTable DT = Conectar(query);

                //Llena Tabla Nota
                String query2 = "INSERT INTO NOTA(MONTO, FECHA, ID_VENTA) VALUES(" + lbltotalPago.Text + ", SYSDATE, " + id + ")";
                DataTable DT2 = Conectar(query2);

                //Llena la Tabla Venta_Producto
                try
                {
                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        String queryinserta = "INSERT INTO PRODUCTO_VENTA VALUES(" + ((productoCantidad)listaProductos[i]).id_Producto + ", " + id + ", " + ((productoCantidad)listaProductos[i]).cantidad + ")";
                        DataTable DTInsert = Conectar(queryinserta);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("mal insertar en producto_venta");
                }



                if (radioContado.Checked)
                {
                    VentaCredito venta = new VentaCredito(lbltotalPago.Text.ToString(), id);
                    venta.Show();

                }
                else
                {
                    MessageBox.Show("Venta Finalizada");
                }


                Nuevo();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al realizar la venta" + error.Message);
            }

            }
            else
            {
                MessageBox.Show("No hay nada que Registrar");
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
