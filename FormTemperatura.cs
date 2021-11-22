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
        private uint tiempo;
        private List<byte> lstTemperatura;
        public FormTemperatura()
        {
            InitializeComponent();
            aleatorio = new Random();
        }
        #region Propiedades
        public byte Temperatura
        {
            get => temperatura;
            set
            {
                if (value > 100)
                {
                    temperatura = 100;
                }
                else
                {
                    temperatura = value;
                }

            }
        }
        #endregion



        private void timerGraficar_Tick(object sender, EventArgs e)
        {
            Temperatura = (byte)aleatorio.Next(120);
            tiempo++;
            dgvTiemTemp.Rows.Add(tiempo, Temperatura);
            chartTemperatura.Series["seTemp"].Points.AddXY(tiempo,Temperatura);
        }

        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerGraficar.Start();
        }

        private void detenerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerGraficar.Stop();
        }

        private void filtrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstTemperatura = new List<byte>();
            for (int i=0; i< dgvTiemTemp.Rows.Count; i++)
            {
                Temperatura = Convert.ToByte( dgvTiemTemp.Rows[i].Cells["ColTemperatura"].Value);
                lstTemperatura.Add(Temperatura);
            }

            FormFiltrarDatos formFiltrarDatos = new FormFiltrarDatos(lstTemperatura);
            formFiltrarDatos.Show();
        }
    }
}
