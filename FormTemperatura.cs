using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de texto | *.txt| Archivo delimitado por ',' *.csv| *.csv|Todos los archivos (*.*) | *.*";
            sfd.DefaultExt = "*.csv";

            StreamWriter sw = null;
            try
            {
                if(  sfd.ShowDialog()  == DialogResult.OK )
                {
                    sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine("Tiempo,Temperatura");
                    for(int i=0; i < dgvTiemTemp.Rows.Count; i++    )
                    {
                        sw.WriteLine("{0},{1}",dgvTiemTemp.Rows[i].Cells["ColTiempo"].Value,dgvTiemTemp.Rows[i].Cells["ColTemperatura"].Value);
                    }
                }
            }
            catch(IOException Error)
            {
                MessageBox.Show("Error", Error.Message);
            }
            finally
            {
                sw.Close();
            }

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto | *.txt| Archivo delimitado por ',' *.csv| *.csv|Todos los archivos (*.*) | *.*";
            ofd.DefaultExt = "*.csv";
            StreamReader sr = null;

            if( ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(ofd.FileName);

                    string linea =sr.ReadLine();
                    linea = sr.ReadLine();
                    while( linea != null   )
                    {
                        string[] datos = linea.Split(',');
                        dgvTiemTemp.Rows.Add(datos[0], datos[1]);
                        linea = sr.ReadLine();
                    }
                }
                catch(IOException error )
                {
                    MessageBox.Show(error.Message, "Error" );
                }
                finally
                {
                    sr.Close();
                }

            }


        }
    }
}
