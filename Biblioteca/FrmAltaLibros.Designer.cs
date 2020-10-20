namespace Biblioteca
{
    partial class FrmAltaLibros
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblNuevo = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.ChkNuevo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.LblFotoPortada = new System.Windows.Forms.Label();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.OfdCargarFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(159, 46);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(35, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(159, 107);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(32, 13);
            this.LblAutor.TabIndex = 1;
            this.LblAutor.Text = "Autor";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Location = new System.Drawing.Point(159, 170);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(44, 13);
            this.LblEditorial.TabIndex = 2;
            this.LblEditorial.Text = "Editorial";
            // 
            // LblNuevo
            // 
            this.LblNuevo.AutoSize = true;
            this.LblNuevo.Location = new System.Drawing.Point(159, 232);
            this.LblNuevo.Name = "LblNuevo";
            this.LblNuevo.Size = new System.Drawing.Size(39, 13);
            this.LblNuevo.TabIndex = 3;
            this.LblNuevo.Text = "Nuevo";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(256, 46);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(100, 20);
            this.TxtTitulo.TabIndex = 4;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(256, 107);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(100, 20);
            this.TxtAutor.TabIndex = 5;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(256, 170);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(100, 20);
            this.TxtEditorial.TabIndex = 6;
            // 
            // ChkNuevo
            // 
            this.ChkNuevo.AutoSize = true;
            this.ChkNuevo.Location = new System.Drawing.Point(256, 232);
            this.ChkNuevo.Name = "ChkNuevo";
            this.ChkNuevo.Size = new System.Drawing.Size(15, 14);
            this.ChkNuevo.TabIndex = 7;
            this.ChkNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(201, 308);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(328, 308);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Location = new System.Drawing.Point(514, 308);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(75, 23);
            this.BtnCargarFoto.TabIndex = 10;
            this.BtnCargarFoto.Text = "Cargar Foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // LblFotoPortada
            // 
            this.LblFotoPortada.AutoSize = true;
            this.LblFotoPortada.Location = new System.Drawing.Point(511, 53);
            this.LblFotoPortada.Name = "LblFotoPortada";
            this.LblFotoPortada.Size = new System.Drawing.Size(93, 13);
            this.LblFotoPortada.TabIndex = 11;
            this.LblFotoPortada.Text = "Foto de la portada";
            // 
            // PicImagen
            // 
            this.PicImagen.Location = new System.Drawing.Point(491, 87);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(122, 123);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 12;
            this.PicImagen.TabStop = false;
            // 
            // OfdCargarFoto
            // 
            this.OfdCargarFoto.FileName = "openFileDialog1";
            // 
            // FrmAltaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicImagen);
            this.Controls.Add(this.LblFotoPortada);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkNuevo);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblNuevo);
            this.Controls.Add(this.LblEditorial);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaLibros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Alta de libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAltaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblNuevo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.CheckBox ChkNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Label LblFotoPortada;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.OpenFileDialog OfdCargarFoto;
    }
}