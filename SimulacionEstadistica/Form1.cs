using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimulacionEstadistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1200, 650); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private async void pictureBoxBotonGirarDados_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.dados);
                player.Play();

                if (!int.TryParse(textBoxNVecesQVaAGirar.Text, out int n) || n <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un número válido de lanzamientos.");
                    return;
                }

                int[] frecuencias = new int[13]; // Índices 2 a 12
                Random rand = new Random();

                chart1.Series.Clear();
                var serie = chart1.Series.Add("Frecuencia Relativa");
                serie.ChartType = SeriesChartType.Column;
                serie.Color = Color.MediumSeaGreen;
                serie.BorderWidth = 2;
                chart1.ChartAreas[0].BackColor = Color.Beige;

                OcultarDados();

                for (int i = 0; i < n; i++)
                {
                    labelNumeroDeTiros.Text = $"Tiro {i + 1}";

                    int dado1 = rand.Next(1, 7);
                    int dado2 = rand.Next(1, 7);
                    int suma = dado1 + dado2;
                    frecuencias[suma]++;

                    MostrarDado(1, dado1);
                    MostrarDado(2, dado2);

                    await Task.Delay(2000);

                    OcultarDados();

                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    dataGridView1.Columns.Add("Etiqueta", "");
                    for (int j = 2; j <= 12; j++)
                    {
                        dataGridView1.Columns.Add(j.ToString(), j.ToString());
                    }

                    var rowAbs = new object[13];
                    rowAbs[0] = "Frecuencia Absoluta";
                    for (int j = 2; j <= 12; j++)
                    {
                        rowAbs[j - 1] = frecuencias[j];
                    }

                    var rowRel = new object[13];
                    rowRel[0] = "Frecuencia Relativa";
                    for (int j = 2; j <= 12; j++)
                    {
                        rowRel[j - 1] = Math.Round((double)frecuencias[j] / (i + 1), 3);
                    }

                    dataGridView1.Rows.Add(rowAbs);
                    dataGridView1.Rows.Add(rowRel);

                    serie.Points.Clear();
                    for (int j = 2; j <= 12; j++)
                    {
                        double rel = (double)frecuencias[j] / (i + 1);
                        serie.Points.AddXY(j, rel);
                    }

                    chart2.Series.Clear();
                    chart2.ChartAreas[0].BackColor = Color.Beige;
                    chart2.ChartAreas[0].AxisX.Title = "Suma de los dados";
                    chart2.ChartAreas[0].AxisY.Minimum = 0;
                    chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

                    var serie2 = chart2.Series.Add("Frecuencia Absoluta");
                    serie2.ChartType = SeriesChartType.Column;
                    serie2.Color = Color.SteelBlue;
                    serie2.BorderWidth = 2;

                    int maxFrecuencia = frecuencias.Max();
                    chart2.ChartAreas[0].AxisY.Maximum = Math.Max(1, ((maxFrecuencia / 5) + 1) * 5); // Ajuste dinámico del eje Y
                    chart2.ChartAreas[0].AxisY.Interval = 1;

                    for (int j = 2; j <= 12; j++)
                    {
                        serie2.Points.AddXY(j, frecuencias[j]);
                    }

                    await Task.Delay(500);
                }

                labelNumeroDeTiros.Text = "Lanzamientos completados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        


        private void OcultarDados()
        {
            
            pictureBoxDado1_01.Visible = false;
            pictureBoxDado1_02.Visible = false;
            pictureBoxDado1_03.Visible = false;
            pictureBoxDado1_04.Visible = false;
            pictureBoxDado1_05.Visible = false;
            pictureBoxDado1_06.Visible = false;

           
            pictureBoxDado2_01.Visible = false;
            pictureBoxBoxDado2_02.Visible = false;
            pictureBoxBoxDado2_03.Visible = false;
            pictureBoxBoxDado2_04.Visible = false;
            pictureBoxBoxDado2_05.Visible = false;
            pictureBoxBoxDado2_06.Visible = false;
        }

        private void MostrarDado(int dadoNumero, int valor)
        {
            
            if (dadoNumero == 1)
            {
                pictureBoxDado1_01.Visible = false;
                pictureBoxDado1_02.Visible = false;
                pictureBoxDado1_03.Visible = false;
                pictureBoxDado1_04.Visible = false;
                pictureBoxDado1_05.Visible = false;
                pictureBoxDado1_06.Visible = false;

                switch (valor)
                {
                    case 1: pictureBoxDado1_01.Visible = true; break;
                    case 2: pictureBoxDado1_02.Visible = true; break;
                    case 3: pictureBoxDado1_03.Visible = true; break;
                    case 4: pictureBoxDado1_04.Visible = true; break;
                    case 5: pictureBoxDado1_05.Visible = true; break;
                    case 6: pictureBoxDado1_06.Visible = true; break;
                }
            }
            else if (dadoNumero == 2)
            {
                pictureBoxDado2_01.Visible = false;
                pictureBoxBoxDado2_02.Visible = false;
                pictureBoxBoxDado2_03.Visible = false;
                pictureBoxBoxDado2_04.Visible = false;
                pictureBoxBoxDado2_05.Visible = false;
                pictureBoxBoxDado2_06.Visible = false;

                switch (valor)
                {
                    case 1: pictureBoxDado2_01.Visible = true; break;
                    case 2: pictureBoxBoxDado2_02.Visible = true; break;
                    case 3: pictureBoxBoxDado2_03.Visible = true; break;
                    case 4: pictureBoxBoxDado2_04.Visible = true; break;
                    case 5: pictureBoxBoxDado2_05.Visible = true; break;
                    case 6: pictureBoxBoxDado2_06.Visible = true; break;
                }
            }
        }
    }
}
