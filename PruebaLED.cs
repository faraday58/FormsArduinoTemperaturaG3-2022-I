using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class PruebaLED : Form
    {
        private bool OnOff=false;
        SerialPort serialPort;
        public PruebaLED(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(OnOff )
            {
                ptbFoco.BackColor = Color.Gray;
                serialPort.Write("a");
                OnOff = false;
            }
            else
            {
                ptbFoco.BackColor = Color.YellowGreen;
                serialPort.Write("p");
                OnOff = true;
            }

        }
    }
}
