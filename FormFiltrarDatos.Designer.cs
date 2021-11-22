
namespace FormsArduinoTemperaturaG3_2022_I
{
    partial class FormFiltrarDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbTempBaja = new System.Windows.Forms.ListBox();
            this.lstbTempAlta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "T < 40 [°C]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "T > 60 [°C]";
            // 
            // lstbTempBaja
            // 
            this.lstbTempBaja.FormattingEnabled = true;
            this.lstbTempBaja.ItemHeight = 25;
            this.lstbTempBaja.Location = new System.Drawing.Point(133, 291);
            this.lstbTempBaja.Name = "lstbTempBaja";
            this.lstbTempBaja.Size = new System.Drawing.Size(246, 629);
            this.lstbTempBaja.TabIndex = 1;
            // 
            // lstbTempAlta
            // 
            this.lstbTempAlta.FormattingEnabled = true;
            this.lstbTempAlta.ItemHeight = 25;
            this.lstbTempAlta.Location = new System.Drawing.Point(640, 291);
            this.lstbTempAlta.Name = "lstbTempAlta";
            this.lstbTempAlta.Size = new System.Drawing.Size(246, 629);
            this.lstbTempAlta.TabIndex = 1;
            // 
            // FormFiltrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 1138);
            this.Controls.Add(this.lstbTempAlta);
            this.Controls.Add(this.lstbTempBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFiltrarDatos";
            this.Text = "FormFiltrarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbTempBaja;
        private System.Windows.Forms.ListBox lstbTempAlta;
    }
}