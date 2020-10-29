namespace PracticaHerencia
{
    partial class FrmAlta
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSNuevo = new System.Windows.Forms.ToolStripButton();
            this.tSGuardar = new System.Windows.Forms.ToolStripButton();
            this.tSBorrar = new System.Windows.Forms.ToolStripButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.ofdSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnEliminarFoto = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSNuevo,
            this.tSGuardar,
            this.tSBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSNuevo
            // 
            this.tSNuevo.AccessibleDescription = "Nuevo";
            this.tSNuevo.Image = global::PracticaHerencia.Properties.Resources.nuevo_usuario__1_;
            this.tSNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSNuevo.Name = "tSNuevo";
            this.tSNuevo.Size = new System.Drawing.Size(46, 35);
            this.tSNuevo.Text = "Nuevo";
            this.tSNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSNuevo.Click += new System.EventHandler(this.tSNuevo_Click);
            // 
            // tSGuardar
            // 
            this.tSGuardar.Image = global::PracticaHerencia.Properties.Resources.guardar_el_archivo;
            this.tSGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSGuardar.Name = "tSGuardar";
            this.tSGuardar.Size = new System.Drawing.Size(53, 35);
            this.tSGuardar.Text = "Guardar";
            this.tSGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSGuardar.ToolTipText = "Guardar";
            this.tSGuardar.Click += new System.EventHandler(this.tSGuardar_Click);
            // 
            // tSBorrar
            // 
            this.tSBorrar.Image = global::PracticaHerencia.Properties.Resources.eliminar_usuario__1_;
            this.tSBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBorrar.Name = "tSBorrar";
            this.tSBorrar.Size = new System.Drawing.Size(43, 35);
            this.tSBorrar.Text = "Borrar";
            this.tSBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSBorrar.Click += new System.EventHandler(this.tSBorrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(422, 212);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comentarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vip";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(532, 212);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(532, 242);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(139, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(532, 274);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(139, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(532, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(532, 334);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(139, 58);
            this.txtComentario.TabIndex = 13;
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Location = new System.Drawing.Point(532, 405);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(15, 14);
            this.chkVip.TabIndex = 14;
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clientes";
            // 
            // lbClientes
            // 
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 16;
            this.lbClientes.Location = new System.Drawing.Point(58, 93);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(266, 212);
            this.lbClientes.Sorted = true;
            this.lbClientes.TabIndex = 16;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // PicFoto
            // 
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFoto.Location = new System.Drawing.Point(510, 65);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(161, 119);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 2;
            this.PicFoto.TabStop = false;
            this.PicFoto.DoubleClick += new System.EventHandler(this.PicFoto_DoubleClick);
            // 
            // ofdSeleccionarImagen
            // 
            this.ofdSeleccionarImagen.FileName = "openFileDialog1";
            // 
            // btnEliminarFoto
            // 
            this.btnEliminarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFoto.Location = new System.Drawing.Point(687, 104);
            this.btnEliminarFoto.Name = "btnEliminarFoto";
            this.btnEliminarFoto.Size = new System.Drawing.Size(74, 49);
            this.btnEliminarFoto.TabIndex = 17;
            this.btnEliminarFoto.Text = "Borrar foto";
            this.btnEliminarFoto.UseVisualStyleBackColor = true;
            this.btnEliminarFoto.Click += new System.EventHandler(this.btnEliminarFoto_Click);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarFoto);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkVip);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAlta";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.PicFoto, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.txtCiudad, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtComentario, 0);
            this.Controls.SetChildIndex(this.chkVip, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbClientes, 0);
            this.Controls.SetChildIndex(this.btnEliminarFoto, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSNuevo;
        private System.Windows.Forms.ToolStripButton tSGuardar;
        private System.Windows.Forms.ToolStripButton tSBorrar;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.CheckBox chkVip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionarImagen;
        private System.Windows.Forms.Button btnEliminarFoto;
    }
}