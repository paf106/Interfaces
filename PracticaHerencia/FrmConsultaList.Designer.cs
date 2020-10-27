namespace PracticaHerencia
{
    partial class FrmConsultaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.cbVista = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.cHnombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHapellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHcomentario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilImagenes = new System.Windows.Forms.ImageList(this.components);
            this.ilIconosGrandes = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vista";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(375, 103);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(152, 21);
            this.cbCiudad.TabIndex = 3;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // cbVista
            // 
            this.cbVista.FormattingEnabled = true;
            this.cbVista.Items.AddRange(new object[] {
            "Detalle",
            "Iconos grandes",
            "Iconos pequeños"});
            this.cbVista.Location = new System.Drawing.Point(624, 103);
            this.cbVista.Name = "cbVista";
            this.cbVista.Size = new System.Drawing.Size(121, 21);
            this.cbVista.Sorted = true;
            this.cbVista.TabIndex = 4;
            this.cbVista.SelectedIndexChanged += new System.EventHandler(this.cbVista_SelectedIndexChanged);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(87, 66);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(100, 100);
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHnombre,
            this.cHapellidos,
            this.cHemail,
            this.cHcomentario});
            this.lvClientes.HideSelection = false;
            this.lvClientes.LargeImageList = this.ilIconosGrandes;
            this.lvClientes.Location = new System.Drawing.Point(242, 220);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(503, 174);
            this.lvClientes.SmallImageList = this.ilImagenes;
            this.lvClientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvClientes.TabIndex = 6;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            // 
            // cHnombre
            // 
            this.cHnombre.Text = "Nombre";
            // 
            // cHapellidos
            // 
            this.cHapellidos.Text = "Apellidos";
            this.cHapellidos.Width = 80;
            // 
            // cHemail
            // 
            this.cHemail.Text = "Email";
            this.cHemail.Width = 100;
            // 
            // cHcomentario
            // 
            this.cHcomentario.Text = "Comentarios";
            this.cHcomentario.Width = 120;
            // 
            // ilImagenes
            // 
            this.ilImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImagenes.ImageStream")));
            this.ilImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImagenes.Images.SetKeyName(0, "usuario.png");
            this.ilImagenes.Images.SetKeyName(1, "estrella.png");
            // 
            // ilIconosGrandes
            // 
            this.ilIconosGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconosGrandes.ImageStream")));
            this.ilIconosGrandes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconosGrandes.Images.SetKeyName(0, "usuario.png");
            this.ilIconosGrandes.Images.SetKeyName(1, "estrella.png");
            // 
            // FrmConsultaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.cbVista);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaList";
            this.Text = "Consulta List";
            this.Load += new System.EventHandler(this.FrmConsultaList_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbCiudad, 0);
            this.Controls.SetChildIndex(this.cbVista, 0);
            this.Controls.SetChildIndex(this.picFoto, 0);
            this.Controls.SetChildIndex(this.lvClientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbVista;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader cHnombre;
        private System.Windows.Forms.ColumnHeader cHapellidos;
        private System.Windows.Forms.ColumnHeader cHemail;
        private System.Windows.Forms.ColumnHeader cHcomentario;
        private System.Windows.Forms.ImageList ilImagenes;
        private System.Windows.Forms.ImageList ilIconosGrandes;
    }
}