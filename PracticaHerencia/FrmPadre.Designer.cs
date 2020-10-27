namespace PracticaHerencia
{
    partial class FrmPadre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultaList = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultaTree = new System.Windows.Forms.ToolStripMenuItem();
            this.iLImagenes = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlta,
            this.MnuConsultaList,
            this.MnuConsultaTree});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuAlta
            // 
            this.MnuAlta.Name = "MnuAlta";
            this.MnuAlta.Size = new System.Drawing.Size(40, 20);
            this.MnuAlta.Text = "Alta";
            this.MnuAlta.Click += new System.EventHandler(this.MnuAlta_Click);
            // 
            // MnuConsultaList
            // 
            this.MnuConsultaList.Name = "MnuConsultaList";
            this.MnuConsultaList.Size = new System.Drawing.Size(90, 20);
            this.MnuConsultaList.Text = "Consulta  List";
            this.MnuConsultaList.Click += new System.EventHandler(this.MnuConsultaList_Click);
            // 
            // MnuConsultaTree
            // 
            this.MnuConsultaTree.Name = "MnuConsultaTree";
            this.MnuConsultaTree.Size = new System.Drawing.Size(90, 20);
            this.MnuConsultaTree.Text = "Consulta Tree";
            this.MnuConsultaTree.Click += new System.EventHandler(this.MnuConsultaTree_Click);
            // 
            // iLImagenes
            // 
            this.iLImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iLImagenes.ImageSize = new System.Drawing.Size(16, 16);
            this.iLImagenes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPadre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPadre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuAlta;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultaList;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultaTree;
        private System.Windows.Forms.ImageList iLImagenes;
    }
}

