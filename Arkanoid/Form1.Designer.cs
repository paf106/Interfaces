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
            this.timerPelota = new System.Windows.Forms.Timer(this.components);
            this.picBarra = new System.Windows.Forms.PictureBox();
            this.picPelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPelota
            // 
            this.timerPelota.Enabled = true;
            this.timerPelota.Interval = 10;
            this.timerPelota.Tick += new System.EventHandler(this.timerPelota_Tick);
            // 
            // picBarra
            // 
            this.picBarra.Image = global::Arkanoid.Properties.Resources.barra;
            this.picBarra.Location = new System.Drawing.Point(297, 363);
            this.picBarra.Name = "picBarra";
            this.picBarra.Size = new System.Drawing.Size(161, 29);
            this.picBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarra.TabIndex = 1;
            this.picBarra.TabStop = false;
            // 
            // picPelota
            // 
            this.picPelota.Image = global::Arkanoid.Properties.Resources.baloncesto__1_;
            this.picPelota.Location = new System.Drawing.Point(240, 140);
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
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.picBarra);
            this.Controls.Add(this.picPelota);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPelota;
        private System.Windows.Forms.Timer timerPelota;
        private System.Windows.Forms.PictureBox picBarra;
    }
}

