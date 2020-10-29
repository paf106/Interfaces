namespace Biblioteca
{
    partial class FrmConsultaLibros
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
            this.GbTipoConsulta = new System.Windows.Forms.GroupBox();
            this.RbEditorial = new System.Windows.Forms.RadioButton();
            this.RbAutor = new System.Windows.Forms.RadioButton();
            this.LsbTitulo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LsbAutorEditorial = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PicFotoLibro = new System.Windows.Forms.PictureBox();
            this.GbTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotoLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // GbTipoConsulta
            // 
            this.GbTipoConsulta.Controls.Add(this.RbEditorial);
            this.GbTipoConsulta.Controls.Add(this.RbAutor);
            this.GbTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTipoConsulta.Location = new System.Drawing.Point(210, 51);
            this.GbTipoConsulta.Name = "GbTipoConsulta";
            this.GbTipoConsulta.Size = new System.Drawing.Size(176, 74);
            this.GbTipoConsulta.TabIndex = 2;
            this.GbTipoConsulta.TabStop = false;
            this.GbTipoConsulta.Text = "Tipo consulta";
            // 
            // RbEditorial
            // 
            this.RbEditorial.AutoSize = true;
            this.RbEditorial.Location = new System.Drawing.Point(19, 42);
            this.RbEditorial.Name = "RbEditorial";
            this.RbEditorial.Size = new System.Drawing.Size(84, 24);
            this.RbEditorial.TabIndex = 1;
            this.RbEditorial.Text = "Editorial";
            this.RbEditorial.UseVisualStyleBackColor = true;
            this.RbEditorial.CheckedChanged += new System.EventHandler(this.RbEditorial_CheckedChanged);
            // 
            // RbAutor
            // 
            this.RbAutor.AutoSize = true;
            this.RbAutor.Location = new System.Drawing.Point(19, 19);
            this.RbAutor.Name = "RbAutor";
            this.RbAutor.Size = new System.Drawing.Size(66, 24);
            this.RbAutor.TabIndex = 0;
            this.RbAutor.Text = "Autor";
            this.RbAutor.UseVisualStyleBackColor = true;
            this.RbAutor.CheckedChanged += new System.EventHandler(this.RbAutor_CheckedChanged);
            // 
            // LsbTitulo
            // 
            this.LsbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbTitulo.FormattingEnabled = true;
            this.LsbTitulo.ItemHeight = 16;
            this.LsbTitulo.Location = new System.Drawing.Point(123, 199);
            this.LsbTitulo.Name = "LsbTitulo";
            this.LsbTitulo.Size = new System.Drawing.Size(120, 84);
            this.LsbTitulo.TabIndex = 3;
            this.LsbTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LsbTitulo_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título:";
            // 
            // LsbAutorEditorial
            // 
            this.LsbAutorEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbAutorEditorial.FormattingEnabled = true;
            this.LsbAutorEditorial.ItemHeight = 16;
            this.LsbAutorEditorial.Location = new System.Drawing.Point(309, 199);
            this.LsbAutorEditorial.Name = "LsbAutorEditorial";
            this.LsbAutorEditorial.Size = new System.Drawing.Size(120, 84);
            this.LsbAutorEditorial.TabIndex = 5;
            this.LsbAutorEditorial.SelectedIndexChanged += new System.EventHandler(this.LsbAutorEditorial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor / Editorial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Foto portada";
            // 
            // PicFotoLibro
            // 
            this.PicFotoLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFotoLibro.Location = new System.Drawing.Point(514, 166);
            this.PicFotoLibro.Name = "PicFotoLibro";
            this.PicFotoLibro.Size = new System.Drawing.Size(135, 142);
            this.PicFotoLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFotoLibro.TabIndex = 8;
            this.PicFotoLibro.TabStop = false;
            // 
            // FrmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicFotoLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LsbAutorEditorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsbTitulo);
            this.Controls.Add(this.GbTipoConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaLibros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consulta de libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbTipoConsulta.ResumeLayout(false);
            this.GbTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotoLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbTipoConsulta;
        private System.Windows.Forms.RadioButton RbEditorial;
        private System.Windows.Forms.RadioButton RbAutor;
        private System.Windows.Forms.ListBox LsbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LsbAutorEditorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicFotoLibro;
    }
}