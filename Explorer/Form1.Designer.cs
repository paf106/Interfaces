
namespace Explorer
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tvDirectorios = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuNuevo = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuCarpeta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichero = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVista = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuDetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIconosGrandes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIconosPequenos = new System.Windows.Forms.ToolStripMenuItem();
            this.lvArchivos = new System.Windows.Forms.ListView();
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaCreacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaModificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaAcceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilIconosGrandes = new System.Windows.Forms.ImageList(this.components);
            this.ilIconosPequenos = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDirectorios
            // 
            this.tvDirectorios.ImageIndex = 0;
            this.tvDirectorios.ImageList = this.imageList1;
            this.tvDirectorios.Location = new System.Drawing.Point(12, 61);
            this.tvDirectorios.Name = "tvDirectorios";
            this.tvDirectorios.SelectedImageIndex = 0;
            this.tvDirectorios.Size = new System.Drawing.Size(225, 355);
            this.tvDirectorios.TabIndex = 0;
            this.tvDirectorios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectorios_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disco-duro (1).png");
            this.imageList1.Images.SetKeyName(1, "carpeta.png");
            this.imageList1.Images.SetKeyName(2, "archivo.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.mnuVista});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarpeta,
            this.mnuFichero});
            this.mnuNuevo.Image = global::Explorer.Properties.Resources.nuevo;
            this.mnuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.Size = new System.Drawing.Size(55, 35);
            this.mnuNuevo.Tag = "";
            this.mnuNuevo.Text = "Nuevo";
            this.mnuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuCarpeta
            // 
            this.mnuCarpeta.Name = "mnuCarpeta";
            this.mnuCarpeta.Size = new System.Drawing.Size(180, 22);
            this.mnuCarpeta.Text = "Carpeta";
            this.mnuCarpeta.Click += new System.EventHandler(this.mnuCarpeta_Click);
            // 
            // mnuFichero
            // 
            this.mnuFichero.Name = "mnuFichero";
            this.mnuFichero.Size = new System.Drawing.Size(180, 22);
            this.mnuFichero.Text = "Fichero";
            this.mnuFichero.Click += new System.EventHandler(this.mnuFichero_Click);
            // 
            // mnuVista
            // 
            this.mnuVista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDetalle,
            this.mnuIconosGrandes,
            this.mnuIconosPequenos});
            this.mnuVista.Image = global::Explorer.Properties.Resources.testigo;
            this.mnuVista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuVista.Name = "mnuVista";
            this.mnuVista.Size = new System.Drawing.Size(45, 35);
            this.mnuVista.Text = "Vista";
            this.mnuVista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuDetalle
            // 
            this.mnuDetalle.Name = "mnuDetalle";
            this.mnuDetalle.Size = new System.Drawing.Size(164, 22);
            this.mnuDetalle.Text = "Detalle";
            this.mnuDetalle.Click += new System.EventHandler(this.mnuDetalle_Click);
            // 
            // mnuIconosGrandes
            // 
            this.mnuIconosGrandes.Name = "mnuIconosGrandes";
            this.mnuIconosGrandes.Size = new System.Drawing.Size(164, 22);
            this.mnuIconosGrandes.Text = "Iconos grandes";
            this.mnuIconosGrandes.Click += new System.EventHandler(this.mnuIconosGrandes_Click);
            // 
            // mnuIconosPequenos
            // 
            this.mnuIconosPequenos.Name = "mnuIconosPequenos";
            this.mnuIconosPequenos.Size = new System.Drawing.Size(164, 22);
            this.mnuIconosPequenos.Text = "Iconos pequeños";
            this.mnuIconosPequenos.Click += new System.EventHandler(this.mnuIconosPequenos_Click);
            // 
            // lvArchivos
            // 
            this.lvArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombre,
            this.columnFechaCreacion,
            this.columnFechaModificacion,
            this.columnFechaAcceso});
            this.lvArchivos.HideSelection = false;
            this.lvArchivos.LargeImageList = this.ilIconosGrandes;
            this.lvArchivos.Location = new System.Drawing.Point(343, 61);
            this.lvArchivos.Name = "lvArchivos";
            this.lvArchivos.Size = new System.Drawing.Size(445, 355);
            this.lvArchivos.SmallImageList = this.ilIconosPequenos;
            this.lvArchivos.TabIndex = 2;
            this.lvArchivos.UseCompatibleStateImageBehavior = false;
            this.lvArchivos.View = System.Windows.Forms.View.Details;
            this.lvArchivos.DoubleClick += new System.EventHandler(this.lvArchivos_DoubleClick);
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            // 
            // columnFechaCreacion
            // 
            this.columnFechaCreacion.Text = "Fecha creacion";
            // 
            // columnFechaModificacion
            // 
            this.columnFechaModificacion.Text = "Fecha modificacion";
            // 
            // columnFechaAcceso
            // 
            this.columnFechaAcceso.Text = "Fecha acceso";
            // 
            // ilIconosGrandes
            // 
            this.ilIconosGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconosGrandes.ImageStream")));
            this.ilIconosGrandes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconosGrandes.Images.SetKeyName(0, "archivo.png");
            this.ilIconosGrandes.Images.SetKeyName(1, "archivo.png");
            this.ilIconosGrandes.Images.SetKeyName(2, "archivo.png");
            // 
            // ilIconosPequenos
            // 
            this.ilIconosPequenos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconosPequenos.ImageStream")));
            this.ilIconosPequenos.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconosPequenos.Images.SetKeyName(0, "archivo.png");
            this.ilIconosPequenos.Images.SetKeyName(1, "archivo.png");
            this.ilIconosPequenos.Images.SetKeyName(2, "archivo.png");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.lvArchivos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tvDirectorios);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectorios;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mnuNuevo;
        private System.Windows.Forms.ToolStripDropDownButton mnuVista;
        private System.Windows.Forms.ToolStripMenuItem mnuCarpeta;
        private System.Windows.Forms.ToolStripMenuItem mnuFichero;
        private System.Windows.Forms.ToolStripMenuItem mnuDetalle;
        private System.Windows.Forms.ToolStripMenuItem mnuIconosGrandes;
        private System.Windows.Forms.ToolStripMenuItem mnuIconosPequenos;
        private System.Windows.Forms.ListView lvArchivos;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnFechaCreacion;
        private System.Windows.Forms.ColumnHeader columnFechaModificacion;
        private System.Windows.Forms.ColumnHeader columnFechaAcceso;
        private System.Windows.Forms.ImageList ilIconosGrandes;
        private System.Windows.Forms.ImageList ilIconosPequenos;
    }
}

