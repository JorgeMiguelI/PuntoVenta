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
    public partial class ContactoCliente : Form
    {
        private OracleConnection Ora;
        private String TipoContacto;
        private int IdCliente;
        public ContactoCliente(int id_Cliente)
        {
            this.IdCliente = id_Cliente;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void ContactoCliente_Load(object sender, EventArgs e)
        {

            Ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TipoContacto = comboBox1.SelectedItem.ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO CONTACTO_CLIENTE(TIPO, DESCRIPCION, ID_CLIENTE) VALUES('" + TipoContacto + "', '" + txt_descripcion.Text + "', " + this.IdCliente + ")";
                DataTable DT = Conectar(query);

                MessageBox.Show("Contacto Guardado");
                txt_descripcion.Text = "";
            }
            catch(Exception error)
            {
                MessageBox.Show("Ah ocurrido un error al Guardar el contacto");
            }
        }
    }
}
