
namespace FormsArduinoTemperaturaG3_2022_I
{
    partial class FormTemperatura
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTiTemp = new System.Windows.Forms.DataGridView();
            this.TimerAdSim = new System.Windows.Forms.Timer(this.components);
            this.ColTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTemperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiTemp)).BeginInit();
            this.cmsDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1598, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.pararToolStripMenuItem,
            this.toolStripMenuItem1,
            this.simularToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // pararToolStripMenuItem
            // 
            this.pararToolStripMenuItem.Name = "pararToolStripMenuItem";
            this.pararToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.pararToolStripMenuItem.Text = "Parar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem1,
            this.detenerToolStripMenuItem});
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.simularToolStripMenuItem.Text = "Simular";
            // 
            // iniciarToolStripMenuItem1
            // 
            this.iniciarToolStripMenuItem1.Name = "iniciarToolStripMenuItem1";
            this.iniciarToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.iniciarToolStripMenuItem1.Text = "Iniciar";
            this.iniciarToolStripMenuItem1.Click += new System.EventHandler(this.iniciarToolStripMenuItem1_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // chartGrafica
            // 
            chartArea3.AxisX.Title = "Tiempo [s]";
            chartArea3.AxisY.Title = "Temperatura [°C]";
            chartArea3.Name = "ChartArea1";
            this.chartGrafica.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGrafica.Legends.Add(legend3);
            this.chartGrafica.Location = new System.Drawing.Point(520, 145);
            this.chartGrafica.Name = "chartGrafica";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura";
            this.chartGrafica.Series.Add(series3);
            this.chartGrafica.Size = new System.Drawing.Size(1023, 605);
            this.chartGrafica.TabIndex = 1;
            this.chartGrafica.Text = "chart1";
            // 
            // dgvTiTemp
            // 
            this.dgvTiTemp.AllowUserToAddRows = false;
            this.dgvTiTemp.AllowUserToDeleteRows = false;
            this.dgvTiTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTiempo,
            this.ColTemperatura});
            this.dgvTiTemp.ContextMenuStrip = this.cmsDatos;
            this.dgvTiTemp.Location = new System.Drawing.Point(33, 190);
            this.dgvTiTemp.Name = "dgvTiTemp";
            this.dgvTiTemp.ReadOnly = true;
            this.dgvTiTemp.RowHeadersWidth = 82;
            this.dgvTiTemp.RowTemplate.Height = 33;
            this.dgvTiTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTiTemp.Size = new System.Drawing.Size(481, 526);
            this.dgvTiTemp.TabIndex = 2;
            // 
            // TimerAdSim
            // 
            this.TimerAdSim.Tick += new System.EventHandler(this.TimerAdSim_Tick);
            // 
            // ColTiempo
            // 
            this.ColTiempo.HeaderText = "Tiempo";
            this.ColTiempo.MinimumWidth = 10;
            this.ColTiempo.Name = "ColTiempo";
            this.ColTiempo.ReadOnly = true;
            this.ColTiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColTemperatura
            // 
            this.ColTemperatura.HeaderText = "Temperatura";
            this.ColTemperatura.MinimumWidth = 10;
            this.ColTemperatura.Name = "ColTemperatura";
            this.ColTemperatura.ReadOnly = true;
            this.ColTemperatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTemperatura.Width = 140;
            // 
            // cmsDatos
            // 
            this.cmsDatos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarDatosToolStripMenuItem});
            this.cmsDatos.Name = "cmsDatos";
            this.cmsDatos.Size = new System.Drawing.Size(219, 42);
            // 
            // filtrarDatosToolStripMenuItem
            // 
            this.filtrarDatosToolStripMenuItem.Name = "filtrarDatosToolStripMenuItem";
            this.filtrarDatosToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.filtrarDatosToolStripMenuItem.Text = "Filtrar Datos";
            this.filtrarDatosToolStripMenuItem.Click += new System.EventHandler(this.filtrarDatosToolStripMenuItem_Click);
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 819);
            this.Controls.Add(this.dgvTiTemp);
            this.Controls.Add(this.chartGrafica);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTemperatura";
            this.Text = "FormTemperatura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiTemp)).EndInit();
            this.cmsDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafica;
        private System.Windows.Forms.DataGridView dgvTiTemp;
        private System.Windows.Forms.Timer TimerAdSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTemperatura;
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.ToolStripMenuItem filtrarDatosToolStripMenuItem;
    }
}