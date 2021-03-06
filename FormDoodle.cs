using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsArduinoTemperaturaG3_2022_I
{
    public partial class FormDoodle : Form
    {
        private bool Izquierda, Derecha, Arriba, Abajo;
        private int velJugador = 8;

        private void FormDoodle_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Right   )
            {
                Derecha = true;
            }
            if( e.KeyCode == Keys.Left)
            {
                Izquierda = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                Abajo = true;
            }

            if(e.KeyCode == Keys.Up)
            {
                Arriba = true;
            }
        }

        private void FormDoodle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Derecha = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                Izquierda = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Abajo = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Arriba = false;
            }
        }

        


        public FormDoodle()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if( Izquierda)
            {
                ptbJugador.Left -= velJugador;
            }
            if( Derecha )
            {
                ptbJugador.Left += velJugador;
            }
            if( Abajo )
            {
                ptbJugador.Top += velJugador;
            }
            if(Arriba)
            {
                ptbJugador.Top -= velJugador;
            }
        }
    }
}
