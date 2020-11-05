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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.picVida1 = new System.Windows.Forms.PictureBox();
            this.picVida2 = new System.Windows.Forms.PictureBox();
            this.picVida3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPelota
            // 
            this.timerPelota.Enabled = true;
            this.timerPelota.Interval = 30;
            this.timerPelota.Tick += new System.EventHandler(this.timerPelota_Tick);
            // 
            // picBarra
            // 
            this.picBarra.BackColor = System.Drawing.Color.Transparent;
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
            this.picPelota.BackColor = System.Drawing.Color.Transparent;
            this.picPelota.Image = global::Arkanoid.Properties.Resources.baloncesto__1_;
            this.picPelota.Location = new System.Drawing.Point(346, 189);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(64, 64);
            this.picPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPelota.TabIndex = 0;
            this.picPelota.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puntuación:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacion.Location = new System.Drawing.Point(123, 9);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(18, 18);
            this.lblPuntuacion.TabIndex = 3;
            this.lblPuntuacion.Text = "0";
            // 
            // picVida1
            // 
            this.picVida1.BackColor = System.Drawing.Color.Transparent;
            this.picVida1.Image = global::Arkanoid.Properties.Resources.corazon;
            this.picVida1.Location = new System.Drawing.Point(90, 30);
            this.picVida1.Name = "picVida1";
            this.picVida1.Size = new System.Drawing.Size(32, 32);
            this.picVida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVida1.TabIndex = 4;
            this.picVida1.TabStop = false;
            // 
            // picVida2
            // 
            this.picVida2.BackColor = System.Drawing.Color.Transparent;
            this.picVida2.Image = global::Arkanoid.Properties.Resources.corazon;
            this.picVida2.Location = new System.Drawing.Point(52, 30);
            this.picVida2.Name = "picVida2";
            this.picVida2.Size = new System.Drawing.Size(32, 32);
            this.picVida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVida2.TabIndex = 5;
            this.picVida2.TabStop = false;
            // 
            // picVida3
            // 
            this.picVida3.BackColor = System.Drawing.Color.Transparent;
            this.picVida3.Image = global::Arkanoid.Properties.Resources.corazon;
            this.picVida3.Location = new System.Drawing.Point(14, 30);
            this.picVida3.Name = "picVida3";
            this.picVida3.Size = new System.Drawing.Size(32, 32);
            this.picVida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVida3.TabIndex = 6;
            this.picVida3.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.fondoPrograma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.picVida3);
            this.Controls.Add(this.picVida2);
            this.Controls.Add(this.picVida1);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBarra);
            this.Controls.Add(this.picPelota);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVida3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPelota;
        private System.Windows.Forms.Timer timerPelota;
        private System.Windows.Forms.PictureBox picBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.PictureBox picVida1;
        private System.Windows.Forms.PictureBox picVida2;
        private System.Windows.Forms.PictureBox picVida3;
    }
}

