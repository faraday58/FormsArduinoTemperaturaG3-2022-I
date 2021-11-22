﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class FormTemperatura : Form
    {
        private byte temperatura;
        private Random aleatorio;
        private List<byte> lstTemperatura;

        private uint tiempo;

        public byte Temperatura { 
            get => temperatura;
            set
            {
                if( temperatura > 100)
                {
                    temperatura = 100;
                }
                else
                {
                    temperatura = value;
                }
                
            }
        }

        public FormTemperatura()
        {
            InitializeComponent();
            aleatorio = new Random();
        }

        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerAdSim.Start();
        }

        private void TimerAdSim_Tick(object sender, EventArgs e)
        {
            Temperatura =(byte)aleatorio.Next(0, 255);
            tiempo++;
            dgvTiTemp.Rows.Add(tiempo, Temperatura);
            chartGrafica.Series["Temperatura"].Points.AddXY(tiempo, Temperatura);
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAdSim.Stop();
        }

        private void filtrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstTemperatura = new List<byte>();
            for (int i=0; i< dgvTiTemp.Rows.Count; i++)
            {
                Temperatura =Convert.ToByte( dgvTiTemp.Rows[i].Cells["ColTemperatura"].Value);
                lstTemperatura.Add(Temperatura);
            }
            FormFiltrarDatos formFiltrar = new FormFiltrarDatos(lstTemperatura);
            formFiltrar.Show();


        }
    }
}
