using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAbarrotes
{
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;
        Ventas ventanaVentas;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {
           
            Size = new Size(880, 680);
            StartPosition = FormStartPosition.CenterScreen;

           Ventas ventanaVentas = new Ventas();
            ventanaVentas.MdiParent = this;
            ventanaVentas.Show();
        }

        private void FileMenu_Click(object sender, EventArgs e)
        {
            Ventas ventanaVentas = new Ventas();
            ventanaVentas.MdiParent = this;
            ventanaVentas.Show();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            
            Existencia ventana_Existencia = new Existencia();
            ventana_Existencia.MdiParent = this;
            ventana_Existencia.Show();
            
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            Actualizar_Prod ventanaAct = new Actualizar_Prod();
            ventanaAct.MdiParent = this;
            ventanaAct.Show();
        }

        private void altasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltasProductos altas = new AltasProductos();
            altas.MdiParent = this;
            altas.Show();
        }

        private void bajasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bajasProductos bajas = new bajasProductos();
            bajas.MdiParent = this;
            bajas.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.MdiParent = this;
            compras.Show();
        }

        private void cuentaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reportes = new Reporte();
            reportes.MdiParent = this;
            reportes.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            Productos_Surtir Surtir = new Productos_Surtir();
            Surtir.MdiParent = this;
            Surtir.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Venta consulta = new Consulta_Venta();
            consulta.MdiParent = this;
            consulta.Show();
        }
    }
}
