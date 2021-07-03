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
    public partial class VentaCredito : Form
    {
        private string PagoVenta = "";
        private int idVenta = 0;
        private OracleConnection Ora;
        public VentaCredito(String pago, int idVenta)
        {
            this.PagoVenta = pago;
            this.idVenta = idVenta;
            InitializeComponent();
        }
        public DataTable Conectar(string query)
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


        private void VentaCredito_Load(object sender, EventArgs e)
        {
            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");
            txt_MontoR.Text = this.PagoVenta;
            

            txtCllienteR.AutoCompleteCustomSource = Datos();
            txtCllienteR.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCllienteR.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private AutoCompleteStringCollection Datos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            String query = "SELECT NOMBRE FROM CLIENTE";
            DataTable DT = Conectar(query);

            for(int i=0; i<DT.Rows.Count; i++)
            {
                datos.Add(DT.Rows[i]["NOMBRE"].ToString());
            }
            return datos;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarVR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCllienteR.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
            }
            else
            {
                try
                {
                    int idCliente;
                    int CuentaCliente;
                    String query1 = "SELECT ID_CLIENTE FROM CLIENTE WHERE NOMBRE=" + "'" + txtCllienteR.Text + "'";
                    DataTable cliente = Conectar(query1);

                    idCliente = Convert.ToInt32(cliente.Rows[0]["ID_CLIENTE"]);

                    //Insertar a la tabla VENTA_CREDITO
                    String query2 = "INSERT INTO VENTA_CREDITO(ID_VENTA, ID_CLIENTE) VALUES(" + this.idVenta + ", " + idCliente + ")";
                    DataTable DT = Conectar(query2);


                    //Consulta para obtener el numero de Cuenta del Cliente
                    String query3 = "SELECT CC.ID_CUENTA FROM CUENTA_CREDITO CC, CLIENTE C, VENTA_CREDITO V" +
                            " WHERE V.ID_CLIENTE =" + idCliente + "AND " + idCliente + "= CC.ID_CLIENTE";
                    DataTable cuenta = Conectar(query3);
                    CuentaCliente = Convert.ToInt32(cuenta.Rows[0]["ID_CUENTA"]);




                    //Metodo Para insertar el movimiento que se ah hecho a la cuenta
                    int idMovimiento = 0;
                    String query4 = "SELECT ID_MOVIMIENTO FROM MOVIMIENTO";
                    DataTable movimiento = Conectar(query4);
                    if (movimiento.Rows.Count > 0)
                    {
                        int pos = movimiento.Rows.Count;
                        idMovimiento = Convert.ToInt32(movimiento.Rows[pos - 1]["ID_MOVIMIENTO"].ToString()) + 1;
                    }
                    else
                    {
                        idMovimiento = 1;
                    }

                    String query5 = " INSERT INTO MOVIMIENTO(ID_MOVIMIENTO, TIPO, CANTIDAD_MOVIMIENTO, ID_CUENTA)" +
                        " VALUES(" + idMovimiento + ", 'Cargo', " + this.PagoVenta + ", " + CuentaCliente + ")";
                    DataTable Mov = Conectar(query5);


                    //Consulta para Obtener el monto de la deuda del cliente
                    String query6 = "SELECT TOTAL_DEUDA FROM CUENTA_CREDITO WHERE ID_CUENTA=" + CuentaCliente;
                    DataTable monto = Conectar(query6);
                    double deuda = Convert.ToDouble(monto.Rows[0]["TOTAL_DEUDA"]) + Convert.ToDouble(this.PagoVenta);

                    //Consulta para Actualizar la deuda de la cuenta del Cliente
                    String query7 = "UPDATE CUENTA_CREDITO SET TOTAL_DEUDA=" + deuda + "WHERE ID_CUENTA=" + CuentaCliente;
                    DataTable nuevoMonto = Conectar(query7);


                    MessageBox.Show("Venta Registrada");
                    this.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show("No se ah registrado la venta Verifique si Cliente existe ");
                }


            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCliente;
            String query = "SELECT ID_CLIENTE FROM CLIENTE";
            DataTable clientes = Conectar(query);
            if (clientes.Rows.Count > 0)
            {
                int pos = clientes.Rows.Count;
                idCliente = Convert.ToInt32(clientes.Rows[pos - 1]["ID_CLIENTE"].ToString()) + 1;
            }
            else
            {
                idCliente = 1;
            }

            try
            {
                String query2 = "INSERT INTO CLIENTE(ID_CLIENTE, NOMBRE, DIRECCION) VALUES(" + idCliente + ", '"+ txt_cliente.Text + "', '" + txt_direccion.Text + "' )";
                DataTable DT = Conectar(query2);

                MessageBox.Show("La Cuenta del cliente ah sido Registrado");
                txt_cliente.Text = "";
                txt_direccion.Text = "";

            }catch(Exception error)
            {
                MessageBox.Show("Ah ocurrido un error al Registrar el Usuario: "+ error.Message);
            }

            try
            {
                String query3 = "INSERT INTO CUENTA_CREDITO(FECHA_LIMITE_PAGO, TOTAL_DEUDA, ID_CLIENTE)  VALUES(ADD_MONTHS(SYSDATE, 1), " + 0 + ", " + idCliente + ")";
                DataTable DT = Conectar(query3);
            }catch(Exception error)
            {
                MessageBox.Show("No se ah podido registrar La Cuenta: "+error.Message);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdCliente;
            String query = "SELECT ID_CLIENTE FROM CLIENTE WHERE NOMBRE= '" + txtCllienteR.Text + "'";
            DataTable DT = Conectar(query);
            IdCliente = Convert.ToInt32(DT.Rows[0]["ID_CLIENTE"]);
            ContactoCliente Contacto = new ContactoCliente(IdCliente);
            Contacto.Show();
                        
        }

        private void btn_agregarCon_Click(object sender, EventArgs e)
        {
            bool verificaNombre = false;
            bool verificaDireccion = false;

            if (String.IsNullOrEmpty(txt_cliente.Text))
            {
                verificaNombre = true;
            }

            if (String.IsNullOrEmpty(txt_direccion.Text))
            {
                verificaDireccion = true;
            }

            if(verificaDireccion || verificaNombre)
            {
                MessageBox.Show("El nombre del cliente o direccion no son correctos");
            }
            else
            {
                int IdCliente;
                String query = "SELECT ID_CLIENTE FROM CLIENTE WHERE NOMBRE= '" + txt_cliente.Text + "'";
                DataTable DT = Conectar(query);
                IdCliente = Convert.ToInt32(DT.Rows[0]["ID_CLIENTE"]);
                ContactoCliente Contacto = new ContactoCliente(IdCliente);
                Contacto.Show();

            }

            
        }
    }
}
