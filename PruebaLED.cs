using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class PruebaLED : Form
    {
        private bool OnOff=false;
        public PruebaLED()
        {
            InitializeComponent();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(OnOff )
            {
                ptbFoco.BackColor = Color.Gray;
                OnOff = false;
            }
            else
            {
                ptbFoco.BackColor = Color.YellowGreen;
                OnOff = true;
            }

        }
    }
}
