
namespace FormsArduinoTemperaturaG3_2022_I
{
    partial class FormDoodle
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
            this.ptbJugador = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbJugador
            // 
            this.ptbJugador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptbJugador.Location = new System.Drawing.Point(134, 219);
            this.ptbJugador.Name = "ptbJugador";
            this.ptbJugador.Size = new System.Drawing.Size(94, 288);
            this.ptbJugador.TabIndex = 0;
            this.ptbJugador.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDoodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 833);
            this.Controls.Add(this.ptbJugador);
            this.Name = "FormDoodle";
            this.Text = "FormDoodle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDoodle_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDoodle_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbJugador;
        private System.Windows.Forms.Timer timer1;
    }
}