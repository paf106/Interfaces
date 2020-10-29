namespace Arkanoid
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPelota
            // 
            this.picPelota.Image = global::Arkanoid.Properties.Resources.baloncesto__1_;
            this.picPelota.Location = new System.Drawing.Point(345, 175);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(64, 64);
            this.picPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPelota.TabIndex = 0;
            this.picPelota.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPelota);
            this.Name = "FrmPrincipal";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPelota;
        private System.Windows.Forms.Timer timer1;
    }
}

