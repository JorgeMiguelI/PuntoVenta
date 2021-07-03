namespace TiendaAbarrotes
{
    partial class Compras
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_datos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.txt_Compras = new System.Windows.Forms.TextBox();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.txt_nombrePro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_registroCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_datos
            // 
            this.groupBox_datos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_datos.Controls.Add(this.button1);
            this.groupBox_datos.Controls.Add(this.btn_compra);
            this.groupBox_datos.Controls.Add(this.txt_Compras);
            this.groupBox_datos.Controls.Add(this.txt_precioCompra);
            this.groupBox_datos.Controls.Add(this.txt_nombrePro);
            this.groupBox_datos.Controls.Add(this.label5);
            this.groupBox_datos.Controls.Add(this.label3);
            this.groupBox_datos.Controls.Add(this.label2);
            this.groupBox_datos.Enabled = false;
            this.groupBox_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datos.Location = new System.Drawing.Point(67, 245);
            this.groupBox_datos.Name = "groupBox_datos";
            this.groupBox_datos.Size = new System.Drawing.Size(677, 305);
            this.groupBox_datos.TabIndex = 4;
            this.groupBox_datos.TabStop = false;
            this.groupBox_datos.Text = "Informacion del Producto";
            // 
            // button1
            // 
            this.button1.Image = global::TiendaAbarrotes.Properties.Resources.finalizar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(223, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Finalizar Compra";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Image = global::TiendaAbarrotes.Properties.Resources.carro;
            this.btn_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_compra.Location = new System.Drawing.Point(18, 216);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(172, 47);
            this.btn_compra.TabIndex = 8;
            this.btn_compra.Text = "Registrar Compra";
            this.btn_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // txt_Compras
            // 
            this.txt_Compras.Location = new System.Drawing.Point(210, 161);
            this.txt_Compras.Name = "txt_Compras";
            this.txt_Compras.Size = new System.Drawing.Size(132, 26);
            this.txt_Compras.TabIndex = 7;
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Location = new System.Drawing.Point(196, 108);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(113, 26);
            this.txt_precioCompra.TabIndex = 5;
            // 
            // txt_nombrePro
            // 
            this.txt_nombrePro.Location = new System.Drawing.Point(196, 57);
            this.txt_nombrePro.Name = "txt_nombrePro";
            this.txt_nombrePro.Size = new System.Drawing.Size(264, 26);
            this.txt_nombrePro.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Image = global::TiendaAbarrotes.Properties.Resources.desbordarse;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "Productos Comprados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Image = global::TiendaAbarrotes.Properties.Resources.costo;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio de Compra:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Image = global::TiendaAbarrotes.Properties.Resources.branding;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del Producto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_registroCompra);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(131, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Compra";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 27);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Image = global::TiendaAbarrotes.Properties.Resources.proveedor;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedor de la Compra:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_registroCompra
            // 
            this.btn_registroCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_registroCompra.Image = global::TiendaAbarrotes.Properties.Resources.agregar;
            this.btn_registroCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registroCompra.Location = new System.Drawing.Point(122, 96);
            this.btn_registroCompra.Name = "btn_registroCompra";
            this.btn_registroCompra.Size = new System.Drawing.Size(257, 47);
            this.btn_registroCompra.TabIndex = 9;
            this.btn_registroCompra.Text = "Registrar una Nueva Compra";
            this.btn_registroCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registroCompra.UseVisualStyleBackColor = false;
            this.btn_registroCompra.Click += new System.EventHandler(this.btn_registroCompra_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::TiendaAbarrotes.Properties.Resources.expediente;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro de Compras de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_datos);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox_datos.ResumeLayout(false);
            this.groupBox_datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_datos;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.TextBox txt_Compras;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.TextBox txt_nombrePro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_registroCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}