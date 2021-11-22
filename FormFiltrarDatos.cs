using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class FormFiltrarDatos : Form
    {
        List<byte> temperaturas;
        List<byte> tempBajas;
        List<byte> tempAltas;
        public FormFiltrarDatos(List<byte> temperaturas)
        {
            InitializeComponent();
            this.temperaturas = temperaturas;
            FiltrarTemperaturas();
        }

        private void FiltrarTemperaturas()
        {
            tempAltas = new List<byte>();
            tempBajas = new List<byte>();

            for (int i=0; i < temperaturas.Count; i++)
            {
                if( temperaturas[i] < 40 )
                {
                    tempBajas.Add(temperaturas[i]);
                    lstbTempBaja.Items.Add(temperaturas[i]);
                }
                else if(temperaturas[i] > 60   )
                {
                    tempAltas.Add(temperaturas[i]);
                    lstbTempAlta.Items.Add(temperaturas[i]);
                }
            }            
        }


    }
}
