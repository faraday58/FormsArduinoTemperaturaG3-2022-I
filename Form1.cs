using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;


        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            tlsCmbVelocidad.SelectedIndex = 1;
            Selecciona();
        }

        private void Selecciona()
        {
            string[] v = SerialPort.GetPortNames();
            Array.Sort(v);
            tlsCmbPuertos.Items.AddRange(v);
        }


        private void pruebaLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaLED formPruebaLed = new PruebaLED(serialPort);
            formPruebaLed.MdiParent = this;
            formPruebaLed.Show();             
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura(serialPort);
            formTemperatura.MdiParent = this;
            formTemperatura.Show();
        }

        private void formDoodleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoodle formDoodle = new FormDoodle();
            formDoodle.Show();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                serialPort.BaudRate = int.Parse(tlsCmbVelocidad.SelectedItem.ToString());
                serialPort.PortName = tlsCmbPuertos.SelectedItem.ToString();
            }
            catch(Exception error )
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            conectarToolStripMenuItem.Enabled = false;
        }
    }
}
