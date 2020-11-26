
namespace Reloj
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuPais = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHoraPaisDiferente = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPais});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(216, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuPais
            // 
            this.mnuPais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnadir,
            this.mnuBorrar,
            this.toolStripMenuItem1});
            this.mnuPais.Name = "mnuPais";
            this.mnuPais.Size = new System.Drawing.Size(41, 22);
            this.mnuPais.Text = "País";
            // 
            // mnuAnadir
            // 
            this.mnuAnadir.Name = "mnuAnadir";
            this.mnuAnadir.Size = new System.Drawing.Size(109, 22);
            this.mnuAnadir.Text = "Añadir";
            this.mnuAnadir.Click += new System.EventHandler(this.mnuAnadir_Click);
            // 
            // mnuBorrar
            // 
            this.mnuBorrar.Name = "mnuBorrar";
            this.mnuBorrar.Size = new System.Drawing.Size(180, 22);
            this.mnuBorrar.Text = "Borrar";
            this.mnuBorrar.Click += new System.EventHandler(this.mnuBorrar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora actual:";
            // 
            // txtHoraActual
            // 
            this.txtHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraActual.Location = new System.Drawing.Point(12, 55);
            this.txtHoraActual.Multiline = true;
            this.txtHoraActual.Name = "txtHoraActual";
            this.txtHoraActual.Size = new System.Drawing.Size(190, 60);
            this.txtHoraActual.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora en ?:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHoraPaisDiferente
            // 
            this.txtHoraPaisDiferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraPaisDiferente.Location = new System.Drawing.Point(12, 152);
            this.txtHoraPaisDiferente.Multiline = true;
            this.txtHoraPaisDiferente.Name = "txtHoraPaisDiferente";
            this.txtHoraPaisDiferente.Size = new System.Drawing.Size(190, 60);
            this.txtHoraPaisDiferente.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 224);
            this.Controls.Add(this.txtHoraPaisDiferente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mnuPais;
        private System.Windows.Forms.ToolStripMenuItem mnuAnadir;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtHoraPaisDiferente;
    }
}

