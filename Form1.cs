using System;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pruebaLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaLED formPruebaLed = new PruebaLED();
            formPruebaLed.MdiParent = this;
            formPruebaLed.Show();
             
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura();
            formTemperatura.MdiParent = this;
            formTemperatura.Show();
        }

        private void formDoodleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoodle formDoodle = new FormDoodle();
            
            formDoodle.Show();
        }
    }
}
