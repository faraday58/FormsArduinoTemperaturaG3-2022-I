using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class FormFiltrarDatos : Form
    {

        List<byte> temperaturas;
        public FormFiltrarDatos(List<byte> temperaturas)
        {
            InitializeComponent();
            this.temperaturas = temperaturas;
            FiltrarTemperaturas();
        }

        private void FiltrarTemperaturas()
        {
            foreach(byte temperatura in temperaturas)
            {
                if( temperatura < 40  )
                {
                    lstbTempBaja.Items.Add(temperatura);
                }
                else if( temperatura > 60)
                {
                    lstbTempAlta.Items.Add(temperatura);
                }    
                
            }
        }

    }
}
