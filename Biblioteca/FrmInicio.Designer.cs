namespace Biblioteca
{
    partial class FrmInicio
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
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuFichero = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.StaBarraAbajo = new System.Windows.Forms.StatusStrip();
            this.LblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mnu.SuspendLayout();
            this.StaBarraAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu
            // 
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichero});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(800, 24);
            this.Mnu.TabIndex = 1;
            this.Mnu.Text = "menuStrip1";
            // 
            // MnuFichero
            // 
            this.MnuFichero.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlta,
            this.MnuConsulta,
            this.toolStripMenuItem1,
            this.MnuSalir});
            this.MnuFichero.Name = "MnuFichero";
            this.MnuFichero.Size = new System.Drawing.Size(58, 20);
            this.MnuFichero.Text = "Fichero";
            this.MnuFichero.Click += new System.EventHandler(this.MnuFichero_Click);
            // 
            // MnuAlta
            // 
            this.MnuAlta.Name = "MnuAlta";
            this.MnuAlta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MnuAlta.Size = new System.Drawing.Size(180, 22);
            this.MnuAlta.Text = "Alta";
            this.MnuAlta.Click += new System.EventHandler(this.MnuAlta_Click);
            // 
            // MnuConsulta
            // 
            this.MnuConsulta.Name = "MnuConsulta";
            this.MnuConsulta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MnuConsulta.Size = new System.Drawing.Size(180, 22);
            this.MnuConsulta.Text = "Consulta";
            this.MnuConsulta.Click += new System.EventHandler(this.MnuConsulta_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuSalir.Size = new System.Drawing.Size(180, 22);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // StaBarraAbajo
            // 
            this.StaBarraAbajo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblTime});
            this.StaBarraAbajo.Location = new System.Drawing.Point(0, 428);
            this.StaBarraAbajo.Name = "StaBarraAbajo";
            this.StaBarraAbajo.Size = new System.Drawing.Size(800, 22);
            this.StaBarraAbajo.TabIndex = 2;
            this.StaBarraAbajo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StaBarraAbajo_ItemClicked);
            // 
            // LblTime
            // 
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(118, 17);
            this.LblTime.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaBarraAbajo);
            this.Controls.Add(this.Mnu);
            this.MainMenuStrip = this.Mnu;
            this.Name = "FrmInicio";
            this.Text = "Gestion Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.StaBarraAbajo.ResumeLayout(false);
            this.StaBarraAbajo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuFichero;
        private System.Windows.Forms.ToolStripMenuItem MnuAlta;
        private System.Windows.Forms.ToolStripMenuItem MnuConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.StatusStrip StaBarraAbajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel LblTime;
    }
}

