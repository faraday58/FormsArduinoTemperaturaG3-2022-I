using System;
using System.Collections.Generic;
using System.IO;
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter= "Archivos de texto | *.txt|Todos los archivos (*.*)|*.*";
            sfd.DefaultExt = ".txt";
            StreamWriter sw = null;

            if (sfd.ShowDialog() == DialogResult.OK && dgvTiTemp.Rows.Count !=0   )                
            {
                try
                {
                    sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine("Tiempo,Temperatura");
                    for (int i = 0; i < dgvTiTemp.Rows.Count; i++)
                    {
                        sw.WriteLine("{0},{1} ", dgvTiTemp.Rows[i].Cells["ColTiempo"].Value.ToString(), dgvTiTemp.Rows[i].Cells["ColTemperatura"].Value.ToString());
                    }
                }
                catch(IOException error)
                {
                    MessageBox.Show("Error", error.Message);
                }                
                catch(Exception error)
                {
                    MessageBox.Show("Error", error.Message);
                }
                finally
                {
                    sw.Close();
                }

            }

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto | *.txt|Todos los archivos (*.*)|*.*";
            ofd.DefaultExt = ".txt";
            StreamReader sr = null;

            if (ofd.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    sr = new StreamReader(ofd.FileName);
                    string linea = sr.ReadLine();
                    linea = sr.ReadLine();
                    while ( linea != null )
                    {                       
                        
                        string[] datos = linea.Split(',');
                        dgvTiTemp.Rows.Add(datos[0],datos[1]);
                        linea = sr.ReadLine();

                    }
                    
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error", error.Message);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error", error.Message);
                }
                finally
                {
                    sr.Close();
                }

            }
        }
    }
}
