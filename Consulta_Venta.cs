using System;
using System.Collections;
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
    public partial class Consulta_Venta : Form
    {

        private OracleConnection Conn;
        private ArrayList Costos = new ArrayList();

        public Consulta_Venta()
        {
            InitializeComponent();
        }

        private DataTable Conectar(String quey)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand(quey, Conn);
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable DT = new DataTable();
            adaptador.Fill(DT);
            Conn.Close();
            return DT;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool ValidaCampo = false;
            for(int i=0;i<txt_codigoVenta.Text.Length; i++)
            {
                if (char.IsLetter(txt_codigoVenta.Text[i]))
                {
                    ValidaCampo = true;
                    break;
                }
            }

            if (String.IsNullOrEmpty(txt_codigoVenta.Text.ToString()) || ValidaCampo)
            {
                MessageBox.Show("Codigo no Valido");
            }
            else
            {

                int idVenta = Convert.ToInt32(txt_codigoVenta.Text.ToString());



                try
                {
                    String queryCosto = "SELECT MONTO FROM VENTA WHERE ID_VENTA= " + idVenta;
                    DataTable M = Conectar(queryCosto);

                    String query = " SELECT PV.id_Venta ID_VENTA, SUM(PV.cant_productos) TOT_PRODUCTOS " +
                        "FROM PRODUCTO_VENTA PV, PRODUCTO P WHERE PV.id_venta =" + idVenta + " AND PV.id_producto = P.id_producto  GROUP BY PV.id_Venta";

                    DataTable DT = Conectar(query);

                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(DT.Rows[0]["ID_VENTA"], DT.Rows[0]["TOT_PRODUCTOS"], M.Rows[0]["MONTO"]);

                }
                catch (Exception error)
                {
                    MessageBox.Show(" Codigo de Venta no Encontrado");
                }

            }

            
            


        }

        private void Consulta_Venta_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            Conn = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");

            try
            {
                String query = " SELECT PV.id_Venta ID_VENTA, SUM(PV.cant_productos) TOT_PRODUCTOS " +
                    "FROM PRODUCTO_VENTA PV, PRODUCTO P WHERE PV.id_producto = P.id_producto" +
                    "  GROUP BY PV.id_Venta";

                DataTable DT = Conectar(query);

                

               for( int i = 0; i < DT.Rows.Count; i++)
                {
                    String queryCostos = "SELECT MONTO FROM VENTA WHERE ID_VENTA =" + DT.Rows[i]["ID_VENTA"];
                    DataTable C = Conectar(queryCostos);
                    Costos.Add(C.Rows[0]["MONTO"]);
                }

                for (int i = 0; i < DT.Rows.Count; i++){
                    dataGridView1.Rows.Add(DT.Rows[i]["ID_VENTA"], DT.Rows[i]["TOT_PRODUCTOS"], "$"+ Costos[i]);
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Ejecutar Consulta");
            }

        }
    }
}
