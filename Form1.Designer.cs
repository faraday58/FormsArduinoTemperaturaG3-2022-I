
namespace FormsArduinoTemperaturaG3_2022_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaLEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semáforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formDoodleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCmbPuertos = new System.Windows.Forms.ToolStripComboBox();
            this.tlsCmbVelocidad = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem,
            this.formDoodleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2282, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertosToolStripMenuItem1,
            this.velocidadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.verificarToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.puertosToolStripMenuItem.Text = "&Configuración";
            // 
            // puertosToolStripMenuItem1
            // 
            this.puertosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCmbPuertos});
            this.puertosToolStripMenuItem1.Name = "puertosToolStripMenuItem1";
            this.puertosToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.puertosToolStripMenuItem1.Size = new System.Drawing.Size(401, 44);
            this.puertosToolStripMenuItem1.Text = "Puertos";
            // 
            // velocidadToolStripMenuItem
            // 
            this.velocidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCmbVelocidad});
            this.velocidadToolStripMenuItem.Name = "velocidadToolStripMenuItem";
            this.velocidadToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.velocidadToolStripMenuItem.Text = "Velocidad";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(398, 6);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.verificarToolStripMenuItem.Text = "Verificar";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.verificarToolStripMenuItem_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(401, 44);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaLEDToolStripMenuItem,
            this.temperaturaToolStripMenuItem,
            this.semáforoToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(167, 38);
            this.aplicacionesToolStripMenuItem.Text = "A&plicaciones";
            // 
            // pruebaLEDToolStripMenuItem
            // 
            this.pruebaLEDToolStripMenuItem.Image = global::FormsArduinoTemperaturaG3_2022_I.Properties.Resources.luz_led;
            this.pruebaLEDToolStripMenuItem.Name = "pruebaLEDToolStripMenuItem";
            this.pruebaLEDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pruebaLEDToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.pruebaLEDToolStripMenuItem.Text = "PruebaLED";
            this.pruebaLEDToolStripMenuItem.Click += new System.EventHandler(this.pruebaLEDToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Image = global::FormsArduinoTemperaturaG3_2022_I.Properties.Resources.termometro;
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // semáforoToolStripMenuItem
            // 
            this.semáforoToolStripMenuItem.Image = global::FormsArduinoTemperaturaG3_2022_I.Properties.Resources.semaforo;
            this.semáforoToolStripMenuItem.Name = "semáforoToolStripMenuItem";
            this.semáforoToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.semáforoToolStripMenuItem.Text = "Semáforo";
            // 
            // formDoodleToolStripMenuItem
            // 
            this.formDoodleToolStripMenuItem.Name = "formDoodleToolStripMenuItem";
            this.formDoodleToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.formDoodleToolStripMenuItem.Text = "FormDoodle";
            this.formDoodleToolStripMenuItem.Click += new System.EventHandler(this.formDoodleToolStripMenuItem_Click);
            // 
            // tlsCmbPuertos
            // 
            this.tlsCmbPuertos.Name = "tlsCmbPuertos";
            this.tlsCmbPuertos.Size = new System.Drawing.Size(121, 40);
            // 
            // tlsCmbVelocidad
            // 
            this.tlsCmbVelocidad.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200"});
            this.tlsCmbVelocidad.Name = "tlsCmbVelocidad";
            this.tlsCmbVelocidad.Size = new System.Drawing.Size(121, 40);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2282, 1234);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Arduino";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem velocidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaLEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semáforoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formDoodleToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tlsCmbPuertos;
        private System.Windows.Forms.ToolStripComboBox tlsCmbVelocidad;
    }
}

