
namespace FormsArduinoTemperaturaG3_2022_I
{
    partial class PruebaLED
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
            this.ptbFoco = new System.Windows.Forms.PictureBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFoco
            // 
            this.ptbFoco.Image = global::FormsArduinoTemperaturaG3_2022_I.Properties.Resources.foco;
            this.ptbFoco.Location = new System.Drawing.Point(229, 62);
            this.ptbFoco.Name = "ptbFoco";
            this.ptbFoco.Size = new System.Drawing.Size(449, 398);
            this.ptbFoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFoco.TabIndex = 0;
            this.ptbFoco.TabStop = false;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(305, 525);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(325, 73);
            this.btnOnOff.TabIndex = 1;
            this.btnOnOff.Text = "ON/OFF";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // PruebaLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 768);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.ptbFoco);
            this.Name = "PruebaLED";
            this.Text = "PruebaLED";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoco;
        private System.Windows.Forms.Button btnOnOff;
    }
}