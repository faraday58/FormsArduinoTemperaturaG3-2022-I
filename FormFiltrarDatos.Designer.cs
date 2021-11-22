
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
            this.lstbTempBaja = new System.Windows.Forms.ListBox();
            this.lstbTempAlta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbTempBaja
            // 
            this.lstbTempBaja.FormattingEnabled = true;
            this.lstbTempBaja.ItemHeight = 25;
            this.lstbTempBaja.Location = new System.Drawing.Point(78, 167);
            this.lstbTempBaja.Name = "lstbTempBaja";
            this.lstbTempBaja.Size = new System.Drawing.Size(206, 554);
            this.lstbTempBaja.TabIndex = 0;
            // 
            // lstbTempAlta
            // 
            this.lstbTempAlta.FormattingEnabled = true;
            this.lstbTempAlta.ItemHeight = 25;
            this.lstbTempAlta.Location = new System.Drawing.Point(468, 167);
            this.lstbTempAlta.Name = "lstbTempAlta";
            this.lstbTempAlta.Size = new System.Drawing.Size(206, 554);
            this.lstbTempAlta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "T < 40 C°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "T > 60 °C";
            // 
            // FormFiltrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 920);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbTempAlta);
            this.Controls.Add(this.lstbTempBaja);
            this.Name = "FormFiltrarDatos";
            this.Text = "FormFiltrarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbTempBaja;
        private System.Windows.Forms.ListBox lstbTempAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}