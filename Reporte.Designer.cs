namespace TiendaAbarrotes
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblventasProm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumVentas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiciembre = new System.Windows.Forms.Label();
            this.lblNoviembre = new System.Windows.Forms.Label();
            this.lblOctubre = new System.Windows.Forms.Label();
            this.lblSeptiembre = new System.Windows.Forms.Label();
            this.lblAgosto = new System.Windows.Forms.Label();
            this.lblJulio = new System.Windows.Forms.Label();
            this.lblJunio = new System.Windows.Forms.Label();
            this.lblMayo = new System.Windows.Forms.Label();
            this.lblAbril = new System.Windows.Forms.Label();
            this.lblMarzo = new System.Windows.Forms.Label();
            this.lblFebrero = new System.Windows.Forms.Label();
            this.lblEnero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Colcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lbltotCompras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen de Ventas del 2019";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 75);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas Mensuales";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(774, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblventasProm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNumVentas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas Totales";
            // 
            // lblventasProm
            // 
            this.lblventasProm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventasProm.ForeColor = System.Drawing.Color.Red;
            this.lblventasProm.Location = new System.Drawing.Point(151, 134);
            this.lblventasProm.Name = "lblventasProm";
            this.lblventasProm.Size = new System.Drawing.Size(90, 17);
            this.lblventasProm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Image = global::TiendaAbarrotes.Properties.Resources.media;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ventas promedio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(151, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 17);
            this.lblTotal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Image = global::TiendaAbarrotes.Properties.Resources.dinero;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumVentas
            // 
            this.lblNumVentas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVentas.ForeColor = System.Drawing.Color.Red;
            this.lblNumVentas.Location = new System.Drawing.Point(151, 41);
            this.lblNumVentas.Name = "lblNumVentas";
            this.lblNumVentas.Size = new System.Drawing.Size(90, 17);
            this.lblNumVentas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = global::TiendaAbarrotes.Properties.Resources.totVentas;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de Ventas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDiciembre);
            this.groupBox2.Controls.Add(this.lblNoviembre);
            this.groupBox2.Controls.Add(this.lblOctubre);
            this.groupBox2.Controls.Add(this.lblSeptiembre);
            this.groupBox2.Controls.Add(this.lblAgosto);
            this.groupBox2.Controls.Add(this.lblJulio);
            this.groupBox2.Controls.Add(this.lblJunio);
            this.groupBox2.Controls.Add(this.lblMayo);
            this.groupBox2.Controls.Add(this.lblAbril);
            this.groupBox2.Controls.Add(this.lblMarzo);
            this.groupBox2.Controls.Add(this.lblFebrero);
            this.groupBox2.Controls.Add(this.lblEnero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(305, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas Por Mes";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(240, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 31);
            this.label16.TabIndex = 33;
            this.label16.Text = "Diciembre";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(240, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 31);
            this.label15.TabIndex = 32;
            this.label15.Text = "Noviembre";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(240, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 31);
            this.label14.TabIndex = 31;
            this.label14.Text = "Octubre";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(240, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 31);
            this.label13.TabIndex = 30;
            this.label13.Text = "Septiembre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(240, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = "Agosto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(240, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 31);
            this.label11.TabIndex = 28;
            this.label11.Text = "Julio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(6, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 31);
            this.label10.TabIndex = 27;
            this.label10.Text = "Junio";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(6, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mayo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Abril";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Marzo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Febrero";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiciembre
            // 
            this.lblDiciembre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiciembre.ForeColor = System.Drawing.Color.Red;
            this.lblDiciembre.Location = new System.Drawing.Point(360, 213);
            this.lblDiciembre.Name = "lblDiciembre";
            this.lblDiciembre.Size = new System.Drawing.Size(133, 15);
            this.lblDiciembre.TabIndex = 22;
            // 
            // lblNoviembre
            // 
            this.lblNoviembre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoviembre.ForeColor = System.Drawing.Color.Red;
            this.lblNoviembre.Location = new System.Drawing.Point(360, 174);
            this.lblNoviembre.Name = "lblNoviembre";
            this.lblNoviembre.Size = new System.Drawing.Size(133, 17);
            this.lblNoviembre.TabIndex = 21;
            // 
            // lblOctubre
            // 
            this.lblOctubre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctubre.ForeColor = System.Drawing.Color.Red;
            this.lblOctubre.Location = new System.Drawing.Point(360, 143);
            this.lblOctubre.Name = "lblOctubre";
            this.lblOctubre.Size = new System.Drawing.Size(125, 17);
            this.lblOctubre.TabIndex = 20;
            // 
            // lblSeptiembre
            // 
            this.lblSeptiembre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeptiembre.ForeColor = System.Drawing.Color.Red;
            this.lblSeptiembre.Location = new System.Drawing.Point(360, 112);
            this.lblSeptiembre.Name = "lblSeptiembre";
            this.lblSeptiembre.Size = new System.Drawing.Size(125, 17);
            this.lblSeptiembre.TabIndex = 4;
            // 
            // lblAgosto
            // 
            this.lblAgosto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgosto.ForeColor = System.Drawing.Color.Red;
            this.lblAgosto.Location = new System.Drawing.Point(356, 79);
            this.lblAgosto.Name = "lblAgosto";
            this.lblAgosto.Size = new System.Drawing.Size(129, 17);
            this.lblAgosto.TabIndex = 19;
            // 
            // lblJulio
            // 
            this.lblJulio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJulio.ForeColor = System.Drawing.Color.Red;
            this.lblJulio.Location = new System.Drawing.Point(360, 39);
            this.lblJulio.Name = "lblJulio";
            this.lblJulio.Size = new System.Drawing.Size(129, 17);
            this.lblJulio.TabIndex = 18;
            // 
            // lblJunio
            // 
            this.lblJunio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJunio.ForeColor = System.Drawing.Color.Red;
            this.lblJunio.Location = new System.Drawing.Point(100, 206);
            this.lblJunio.Name = "lblJunio";
            this.lblJunio.Size = new System.Drawing.Size(129, 17);
            this.lblJunio.TabIndex = 17;
            // 
            // lblMayo
            // 
            this.lblMayo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayo.ForeColor = System.Drawing.Color.Red;
            this.lblMayo.Location = new System.Drawing.Point(100, 174);
            this.lblMayo.Name = "lblMayo";
            this.lblMayo.Size = new System.Drawing.Size(129, 15);
            this.lblMayo.TabIndex = 16;
            // 
            // lblAbril
            // 
            this.lblAbril.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbril.ForeColor = System.Drawing.Color.Red;
            this.lblAbril.Location = new System.Drawing.Point(100, 143);
            this.lblAbril.Name = "lblAbril";
            this.lblAbril.Size = new System.Drawing.Size(129, 17);
            this.lblAbril.TabIndex = 15;
            // 
            // lblMarzo
            // 
            this.lblMarzo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarzo.ForeColor = System.Drawing.Color.Red;
            this.lblMarzo.Location = new System.Drawing.Point(100, 112);
            this.lblMarzo.Name = "lblMarzo";
            this.lblMarzo.Size = new System.Drawing.Size(129, 17);
            this.lblMarzo.TabIndex = 14;
            // 
            // lblFebrero
            // 
            this.lblFebrero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFebrero.ForeColor = System.Drawing.Color.Red;
            this.lblFebrero.Location = new System.Drawing.Point(100, 79);
            this.lblFebrero.Name = "lblFebrero";
            this.lblFebrero.Size = new System.Drawing.Size(129, 17);
            this.lblFebrero.TabIndex = 13;
            // 
            // lblEnero
            // 
            this.lblEnero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnero.ForeColor = System.Drawing.Color.Red;
            this.lblEnero.Location = new System.Drawing.Point(100, 48);
            this.lblEnero.Name = "lblEnero";
            this.lblEnero.Size = new System.Drawing.Size(129, 17);
            this.lblEnero.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Image = global::TiendaAbarrotes.Properties.Resources.ventasmeses;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enero";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Image = global::TiendaAbarrotes.Properties.Resources.analitica;
            this.label17.Location = new System.Drawing.Point(22, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 59);
            this.label17.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.lblDeuda);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(16, 555);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 201);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes con Deudas";
            // 
            // lblDeuda
            // 
            this.lblDeuda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeuda.Image = global::TiendaAbarrotes.Properties.Resources.dinero;
            this.lblDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeuda.Location = new System.Drawing.Point(134, 25);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(107, 50);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Total Deuda";
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Image = global::TiendaAbarrotes.Properties.Resources.hombre;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 39);
            this.label23.TabIndex = 0;
            this.label23.Text = "Cliente";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colcliente,
            this.ColDescripcion});
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(241, 124);
            this.dataGridView1.TabIndex = 47;
            // 
            // Colcliente
            // 
            this.Colcliente.HeaderText = "Cliente";
            this.Colcliente.Name = "Colcliente";
            this.Colcliente.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Total Deuda";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.lbltotCompras);
            this.groupBox4.Controls.Add(this.lblProducto);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox4.Location = new System.Drawing.Point(305, 642);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 114);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto mas Comprado";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Image = global::TiendaAbarrotes.Properties.Resources.desbordarse;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(134, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 50);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Compras";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Image = global::TiendaAbarrotes.Properties.Resources.costo;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(6, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 39);
            this.label19.TabIndex = 0;
            this.label19.Text = "Producto";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Red;
            this.lblProducto.Location = new System.Drawing.Point(6, 75);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(122, 23);
            this.lblProducto.TabIndex = 34;
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltotCompras
            // 
            this.lbltotCompras.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotCompras.ForeColor = System.Drawing.Color.Red;
            this.lbltotCompras.Location = new System.Drawing.Point(146, 75);
            this.lbltotCompras.Name = "lbltotCompras";
            this.lbltotCompras.Size = new System.Drawing.Size(125, 23);
            this.lbltotCompras.TabIndex = 35;
            this.lbltotCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblventasProm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDiciembre;
        private System.Windows.Forms.Label lblNoviembre;
        private System.Windows.Forms.Label lblOctubre;
        private System.Windows.Forms.Label lblSeptiembre;
        private System.Windows.Forms.Label lblAgosto;
        private System.Windows.Forms.Label lblJulio;
        private System.Windows.Forms.Label lblJunio;
        private System.Windows.Forms.Label lblMayo;
        private System.Windows.Forms.Label lblAbril;
        private System.Windows.Forms.Label lblMarzo;
        private System.Windows.Forms.Label lblFebrero;
        private System.Windows.Forms.Label lblEnero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltotCompras;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}