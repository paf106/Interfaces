namespace Trivial
{
    partial class FrmPrincipal
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreCapitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombrePaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.multiplesOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirRespuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.LblCapital = new System.Windows.Forms.Label();
            this.TxtCapital1 = new System.Windows.Forms.TextBox();
            this.TxtCapital2 = new System.Windows.Forms.TextBox();
            this.TxtCapital3 = new System.Windows.Forms.TextBox();
            this.TxtCapital4 = new System.Windows.Forms.TextBox();
            this.TxtPorcentajeAciertos = new System.Windows.Forms.TextBox();
            this.BtnSiguente = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPartida,
            this.MnuOpciones});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(217, 24);
            this.MnuPrincipal.TabIndex = 0;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuPartida
            // 
            this.MnuPartida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNueva,
            this.MnuSalir});
            this.MnuPartida.Name = "MnuPartida";
            this.MnuPartida.Size = new System.Drawing.Size(56, 20);
            this.MnuPartida.Text = "Partida";
            // 
            // MnuNueva
            // 
            this.MnuNueva.Name = "MnuNueva";
            this.MnuNueva.Size = new System.Drawing.Size(108, 22);
            this.MnuNueva.Text = "Nueva";
            this.MnuNueva.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(108, 22);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // MnuOpciones
            // 
            this.MnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreCapitalesToolStripMenuItem,
            this.nombrePaisesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.multiplesOpcionesToolStripMenuItem,
            this.escribirRespuestaToolStripMenuItem});
            this.MnuOpciones.Name = "MnuOpciones";
            this.MnuOpciones.Size = new System.Drawing.Size(69, 20);
            this.MnuOpciones.Text = "Opciones";
            // 
            // nombreCapitalesToolStripMenuItem
            // 
            this.nombreCapitalesToolStripMenuItem.Name = "nombreCapitalesToolStripMenuItem";
            this.nombreCapitalesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nombreCapitalesToolStripMenuItem.Text = "Nombre Capitales";
            // 
            // nombrePaisesToolStripMenuItem
            // 
            this.nombrePaisesToolStripMenuItem.Name = "nombrePaisesToolStripMenuItem";
            this.nombrePaisesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nombrePaisesToolStripMenuItem.Text = "Nombre Paises";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // multiplesOpcionesToolStripMenuItem
            // 
            this.multiplesOpcionesToolStripMenuItem.Name = "multiplesOpcionesToolStripMenuItem";
            this.multiplesOpcionesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.multiplesOpcionesToolStripMenuItem.Text = "Multiples opciones";
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            this.escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            this.escribirRespuestaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.escribirRespuestaToolStripMenuItem.Text = "Escribir respuesta";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(12, 38);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(30, 13);
            this.LblPais.TabIndex = 1;
            this.LblPais.Text = "Pais:";
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(48, 35);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.ReadOnly = true;
            this.TxtPais.Size = new System.Drawing.Size(100, 20);
            this.TxtPais.TabIndex = 2;
            this.TxtPais.TextChanged += new System.EventHandler(this.TxtPais_TextChanged);
            // 
            // LblCapital
            // 
            this.LblCapital.AutoSize = true;
            this.LblCapital.Location = new System.Drawing.Point(75, 84);
            this.LblCapital.Name = "LblCapital";
            this.LblCapital.Size = new System.Drawing.Size(42, 13);
            this.LblCapital.TabIndex = 3;
            this.LblCapital.Text = "Capital:";
            // 
            // TxtCapital1
            // 
            this.TxtCapital1.Location = new System.Drawing.Point(48, 109);
            this.TxtCapital1.Name = "TxtCapital1";
            this.TxtCapital1.ReadOnly = true;
            this.TxtCapital1.Size = new System.Drawing.Size(100, 20);
            this.TxtCapital1.TabIndex = 4;
            this.TxtCapital1.Click += new System.EventHandler(this.TxtCapital1_TextChanged);
            // 
            // TxtCapital2
            // 
            this.TxtCapital2.Location = new System.Drawing.Point(48, 135);
            this.TxtCapital2.Name = "TxtCapital2";
            this.TxtCapital2.ReadOnly = true;
            this.TxtCapital2.Size = new System.Drawing.Size(100, 20);
            this.TxtCapital2.TabIndex = 5;
            this.TxtCapital2.Click += new System.EventHandler(this.TxtCapital2_TextChanged);
            // 
            // TxtCapital3
            // 
            this.TxtCapital3.Location = new System.Drawing.Point(48, 161);
            this.TxtCapital3.Name = "TxtCapital3";
            this.TxtCapital3.ReadOnly = true;
            this.TxtCapital3.Size = new System.Drawing.Size(100, 20);
            this.TxtCapital3.TabIndex = 6;
            this.TxtCapital3.Click += new System.EventHandler(this.TxtCapital3_TextChanged);
            // 
            // TxtCapital4
            // 
            this.TxtCapital4.Location = new System.Drawing.Point(48, 187);
            this.TxtCapital4.Name = "TxtCapital4";
            this.TxtCapital4.ReadOnly = true;
            this.TxtCapital4.Size = new System.Drawing.Size(100, 20);
            this.TxtCapital4.TabIndex = 7;
            this.TxtCapital4.Click += new System.EventHandler(this.TxtCapital4_TextChanged);
            // 
            // TxtPorcentajeAciertos
            // 
            this.TxtPorcentajeAciertos.Location = new System.Drawing.Point(96, 228);
            this.TxtPorcentajeAciertos.Name = "TxtPorcentajeAciertos";
            this.TxtPorcentajeAciertos.Size = new System.Drawing.Size(23, 20);
            this.TxtPorcentajeAciertos.TabIndex = 8;
            // 
            // BtnSiguente
            // 
            this.BtnSiguente.Enabled = false;
            this.BtnSiguente.Location = new System.Drawing.Point(125, 228);
            this.BtnSiguente.Name = "BtnSiguente";
            this.BtnSiguente.Size = new System.Drawing.Size(75, 23);
            this.BtnSiguente.TabIndex = 9;
            this.BtnSiguente.Text = "Siguiente";
            this.BtnSiguente.UseVisualStyleBackColor = true;
            this.BtnSiguente.Click += new System.EventHandler(this.BtnSiguente_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(15, 225);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 272);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSiguente);
            this.Controls.Add(this.TxtPorcentajeAciertos);
            this.Controls.Add(this.TxtCapital4);
            this.Controls.Add(this.TxtCapital3);
            this.Controls.Add(this.TxtCapital2);
            this.Controls.Add(this.TxtCapital1);
            this.Controls.Add(this.LblCapital);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.MnuPrincipal);
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Trivial";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuPartida;
        private System.Windows.Forms.ToolStripMenuItem MnuNueva;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem nombreCapitalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombrePaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiplesOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirRespuestaToolStripMenuItem;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label LblCapital;
        private System.Windows.Forms.TextBox TxtCapital1;
        private System.Windows.Forms.TextBox TxtCapital2;
        private System.Windows.Forms.TextBox TxtCapital3;
        private System.Windows.Forms.TextBox TxtCapital4;
        private System.Windows.Forms.TextBox TxtPorcentajeAciertos;
        private System.Windows.Forms.Button BtnSiguente;
        private System.Windows.Forms.Button BtnSalir;
    }
}

