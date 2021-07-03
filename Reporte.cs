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
using System.Windows.Forms.DataVisualization.Charting;

namespace TiendaAbarrotes
{
    public partial class Reporte : Form
    {
        private OracleConnection Conn;
        public Reporte()
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

        private void Reporte_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            Conn = new OracleConnection("DATA SOURCE = orcl; PASSWORD = Hola; USER ID = HUMBERTO;");


            //Producto mas Comprado

            try
            {
                String query = "SELECT *from(SELECT producto, num_compras, rank() over (ORDER BY NUM_COMPRAS DESC) rnk FROM PROD_MASCOMPRADO) WHERE rnk<= 1";
                DataTable prod = Conectar(query);
                lblProducto.Text = prod.Rows[0]["PRODUCTO"].ToString();
                lbltotCompras.Text = prod.Rows[0]["NUM_COMPRAS"].ToString();

            }catch(Exception error)
            {
                MessageBox.Show("Error al traer el producto mas comprado "+ error.Message);
            }

            //Clientes con deudas
            try
            {
                String query = "SELECT *FROM CLIENTE_DEUDA";
                DataTable deudas = Conectar(query);

                for(int i = 0; i < deudas.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(deudas.Rows[i]["CLIENTE"], "$"+ deudas.Rows[i]["DEUDA"]);
                }


            }catch(Exception error)
            {
                MessageBox.Show("Error");
            }



            int ventasEn = 0;
            int ventasFe = 0;
            int ventasMa = 0;
            int ventasAb = 0;
            int ventasMay = 0;
            int ventasJun = 0;
            int ventasJul = 0;
            int ventasAg = 0;
            int ventasSep = 0;
            int ventasOct = 0;
            int ventasDic = 0;
            int ventasNov = 0;
            //Nos Traemos las ventas mensuales
            try
            {
                // Ventas del mes de Enero
                String queryE = "SELECT VENTA_MENSUAL('01/01/19', '31/01/19') VENTA_MENSUAL FROM DUAL";
                DataTable En = Conectar(queryE);
                
                if(En.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasEn = 0;
                }
                else
                {
                    ventasEn = Convert.ToInt32(En.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                // Ventas del mes de Febrero
                String queryF = "SELECT VENTA_MENSUAL('01/02/19', '28/02/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Fe = Conectar(queryF);
                
                if (Fe.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasFe = 0;
                }
                else
                {
                    ventasFe = Convert.ToInt32(Fe.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Marzo
                String queryM = "SELECT VENTA_MENSUAL('01/03/19', '31/03/19') VENTA_MENSUAL FROM DUAL";
                DataTable Ma = Conectar(queryM);
                
                if (Ma.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasMa = 0;
                }
                else
                {
                    ventasMa = Convert.ToInt32(Ma.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Abril
                String queryA = "SELECT VENTA_MENSUAL('01/04/19', '30/04/19') VENTA_MENSUAL FROM DUAL";
                DataTable Ab = Conectar(queryA);
                
                if (Ab.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasAb = 0;
                }
                else
                {
                    ventasAb = Convert.ToInt32(Ab.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Mayo
                String queryMa = "SELECT VENTA_MENSUAL('01/05/19', '31/05/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable May = Conectar(queryMa);
                
                if (May.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasMay = 0;
                }
                else
                {
                    ventasMay = Convert.ToInt32(May.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Junio
                String queryJ = "SELECT VENTA_MENSUAL('01/06/19', '30/06/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Ju = Conectar(queryJ);
                
                if (Ju.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasJun = 0;
                }
                else
                {
                    ventasJun = Convert.ToInt32(Ju.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Julio
                String queryJul = "SELECT VENTA_MENSUAL('01/07/19', '31/07/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Jul = Conectar(queryJul);
                
                if (Jul.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasJul = 0;
                }
                else
                {
                    ventasJul = Convert.ToInt32(Jul.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Agosto
                String queryAg = "SELECT VENTA_MENSUAL('01/08/19', '31/08/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Ag = Conectar(queryAg);
                
                if (Ag.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasAg = 0;
                }
                else
                {
                    ventasAg = Convert.ToInt32(Ag.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Septiembre
                String queryS = "SELECT VENTA_MENSUAL('01/09/19', '30/09/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Se = Conectar(queryS);
                
                if (Se.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasSep = 0;
                }
                else
                {
                    ventasSep = Convert.ToInt32(Se.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Octubre
                String queryO = "SELECT VENTA_MENSUAL('01/10/19', '31/10/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Oc = Conectar(queryO);
                
                if (Oc.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasOct = 0;
                }
                else
                {
                    ventasOct = Convert.ToInt32(Oc.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                //Ventas del mes de Diciembre
                String queryD = "SELECT VENTA_MENSUAL('01/12/19', '31/12/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Di = Conectar(queryD);

                
                if (Di.Rows[0]["VENTA_MENSUAL"].ToString() =="")
                {
                    ventasDic = 0;

                }
                else
                {
                    ventasDic = Convert.ToInt32(Di.Rows[0]["VENTA_MENSUAL"].ToString());
                }


                // Ventas del mes de Noviembre
                String queryN = "SELECT VENTA_MENSUAL('01/11/19', '30/11/19') VENTA_MENSUAL FROM DUAL" ;
                DataTable Nov = Conectar(queryN);

               
                if (Nov.Rows[0]["VENTA_MENSUAL"].ToString() == "")
                {
                    ventasNov = 0;

                }
                else
                {
                    ventasNov = Convert.ToInt32(Nov.Rows[0]["VENTA_MENSUAL"].ToString());
                }

                // Vectores con los Datos
                string[] meses = { "En", "Feb", "Mar", "Ab", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
                int[] totVentas = { ventasEn, ventasFe, ventasMa, ventasAb, ventasMay,ventasJun, ventasJul, ventasAg, ventasSep, ventasOct, ventasNov, ventasDic };

            

            //Cambiar la Combinacion de Colores
            chart1.Palette = ChartColorPalette.SeaGreen;

            chart1.Titles.Add("Ventas Mensuales del 2019");
            chart1.Series[0].Points.DataBindXY(meses, totVentas);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }


            //Nos traemos la ventas totales del año
            try
            {
                String querytotventas = "SELECT NUM_VENTAS() TOT_VENTAS FROM DUAL";
                DataTable TotVentas = Conectar(querytotventas);

                String querymontoVentas = "SELECT SUM(MONTO) COSTOTOT FROM VENTA";
                DataTable montoVentas = Conectar(querymontoVentas);

                String queryventasProm = "SELECT AVG(MONTO) VENTAPROM FROM VENTA";
                DataTable PromVentas = Conectar(queryventasProm);

                lblTotal.Text = "$" + montoVentas.Rows[0]["COSTOTOT"].ToString();
                lblNumVentas.Text = TotVentas.Rows[0]["TOT_VENTAS"].ToString();
                lblventasProm.Text = "$" + PromVentas.Rows[0]["VENTAPROM"].ToString();
            }catch(Exception error)
            {
                MessageBox.Show("Algo ah salido mal "+ error.Message);
            }

            String queryventas = "SELECT SUM(MONTO) MONTO FROM VENTA GROUP BY ID_VENTA";
            DataTable ventas = Conectar(queryventas);

            //Ventas Totales por mes
            lblEnero.Text = "$" + ventasEn;
            lblFebrero.Text = "$" + ventasFe;
            lblMarzo.Text = "$" + ventasMa;
            lblAbril.Text = "$" + ventasAb;
            lblMayo.Text = "$" + ventasMay;
            lblJunio.Text = "$" + ventasJun;
            lblJulio.Text = "$" + ventasJul;
            lblAgosto.Text = "$" + ventasAg;
            lblSeptiembre.Text = "$" + ventasSep;
            lblOctubre.Text = "$" + ventasOct;
            lblNoviembre.Text = "$" + ventasNov;
            lblDiciembre.Text = "$" + ventasDic;
        }
    }
}
