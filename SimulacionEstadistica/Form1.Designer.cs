namespace SimulacionEstadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBotonGirarDados = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxDado1_01 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1_02 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1_03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1_04 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1_05 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1_06 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxDado2_06 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxDado2_05 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxDado2_04 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxDado2_03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoxDado2_02 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado2_01 = new System.Windows.Forms.PictureBox();
            this.textBoxNVecesQVaAGirar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumeroDeTiros = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotonGirarDados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimulacionEstadistica.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(30, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1223, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBotonGirarDados
            // 
            this.pictureBoxBotonGirarDados.BackgroundImage = global::SimulacionEstadistica.Properties.Resources.imagenSoporte;
            this.pictureBoxBotonGirarDados.Image = global::SimulacionEstadistica.Properties.Resources.dices_9017_128;
            this.pictureBoxBotonGirarDados.Location = new System.Drawing.Point(40, 72);
            this.pictureBoxBotonGirarDados.Name = "pictureBoxBotonGirarDados";
            this.pictureBoxBotonGirarDados.Size = new System.Drawing.Size(183, 135);
            this.pictureBoxBotonGirarDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBotonGirarDados.TabIndex = 1;
            this.pictureBoxBotonGirarDados.TabStop = false;
            this.pictureBoxBotonGirarDados.Click += new System.EventHandler(this.pictureBoxBotonGirarDados_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxBotonGirarDados);
            this.panel2.Location = new System.Drawing.Point(1382, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 238);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tirar Dados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(30, 702);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1223, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1277, 479);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(454, 217);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBoxDado1_01
            // 
            this.pictureBoxDado1_01.Image = global::SimulacionEstadistica.Properties.Resources._1;
            this.pictureBoxDado1_01.Location = new System.Drawing.Point(58, 258);
            this.pictureBoxDado1_01.Name = "pictureBoxDado1_01";
            this.pictureBoxDado1_01.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxDado1_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_01.TabIndex = 4;
            this.pictureBoxDado1_01.TabStop = false;
            // 
            // pictureBoxDado1_02
            // 
            this.pictureBoxDado1_02.Image = global::SimulacionEstadistica.Properties.Resources._2;
            this.pictureBoxDado1_02.Location = new System.Drawing.Point(254, 258);
            this.pictureBoxDado1_02.Name = "pictureBoxDado1_02";
            this.pictureBoxDado1_02.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxDado1_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_02.TabIndex = 5;
            this.pictureBoxDado1_02.TabStop = false;
            // 
            // pictureBoxDado1_03
            // 
            this.pictureBoxDado1_03.Image = global::SimulacionEstadistica.Properties.Resources._3;
            this.pictureBoxDado1_03.Location = new System.Drawing.Point(450, 258);
            this.pictureBoxDado1_03.Name = "pictureBoxDado1_03";
            this.pictureBoxDado1_03.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxDado1_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_03.TabIndex = 6;
            this.pictureBoxDado1_03.TabStop = false;
            // 
            // pictureBoxDado1_04
            // 
            this.pictureBoxDado1_04.Image = global::SimulacionEstadistica.Properties.Resources._4;
            this.pictureBoxDado1_04.Location = new System.Drawing.Point(647, 258);
            this.pictureBoxDado1_04.Name = "pictureBoxDado1_04";
            this.pictureBoxDado1_04.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxDado1_04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_04.TabIndex = 7;
            this.pictureBoxDado1_04.TabStop = false;
            // 
            // pictureBoxDado1_05
            // 
            this.pictureBoxDado1_05.Image = global::SimulacionEstadistica.Properties.Resources._5;
            this.pictureBoxDado1_05.Location = new System.Drawing.Point(842, 258);
            this.pictureBoxDado1_05.Name = "pictureBoxDado1_05";
            this.pictureBoxDado1_05.Size = new System.Drawing.Size(182, 169);
            this.pictureBoxDado1_05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_05.TabIndex = 8;
            this.pictureBoxDado1_05.TabStop = false;
            // 
            // pictureBoxDado1_06
            // 
            this.pictureBoxDado1_06.Image = global::SimulacionEstadistica.Properties.Resources._6;
            this.pictureBoxDado1_06.Location = new System.Drawing.Point(1030, 258);
            this.pictureBoxDado1_06.Name = "pictureBoxDado1_06";
            this.pictureBoxDado1_06.Size = new System.Drawing.Size(191, 169);
            this.pictureBoxDado1_06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado1_06.TabIndex = 9;
            this.pictureBoxDado1_06.TabStop = false;
            // 
            // pictureBoxBoxDado2_06
            // 
            this.pictureBoxBoxDado2_06.Image = global::SimulacionEstadistica.Properties.Resources._6;
            this.pictureBoxBoxDado2_06.Location = new System.Drawing.Point(1030, 479);
            this.pictureBoxBoxDado2_06.Name = "pictureBoxBoxDado2_06";
            this.pictureBoxBoxDado2_06.Size = new System.Drawing.Size(191, 169);
            this.pictureBoxBoxDado2_06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoxDado2_06.TabIndex = 15;
            this.pictureBoxBoxDado2_06.TabStop = false;
            // 
            // pictureBoxBoxDado2_05
            // 
            this.pictureBoxBoxDado2_05.Image = global::SimulacionEstadistica.Properties.Resources._5;
            this.pictureBoxBoxDado2_05.Location = new System.Drawing.Point(842, 479);
            this.pictureBoxBoxDado2_05.Name = "pictureBoxBoxDado2_05";
            this.pictureBoxBoxDado2_05.Size = new System.Drawing.Size(182, 169);
            this.pictureBoxBoxDado2_05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoxDado2_05.TabIndex = 14;
            this.pictureBoxBoxDado2_05.TabStop = false;
            // 
            // pictureBoxBoxDado2_04
            // 
            this.pictureBoxBoxDado2_04.Image = global::SimulacionEstadistica.Properties.Resources._4;
            this.pictureBoxBoxDado2_04.Location = new System.Drawing.Point(647, 479);
            this.pictureBoxBoxDado2_04.Name = "pictureBoxBoxDado2_04";
            this.pictureBoxBoxDado2_04.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxBoxDado2_04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoxDado2_04.TabIndex = 13;
            this.pictureBoxBoxDado2_04.TabStop = false;
            // 
            // pictureBoxBoxDado2_03
            // 
            this.pictureBoxBoxDado2_03.Image = global::SimulacionEstadistica.Properties.Resources._3;
            this.pictureBoxBoxDado2_03.Location = new System.Drawing.Point(450, 479);
            this.pictureBoxBoxDado2_03.Name = "pictureBoxBoxDado2_03";
            this.pictureBoxBoxDado2_03.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxBoxDado2_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoxDado2_03.TabIndex = 12;
            this.pictureBoxBoxDado2_03.TabStop = false;
            // 
            // pictureBoxBoxDado2_02
            // 
            this.pictureBoxBoxDado2_02.Image = global::SimulacionEstadistica.Properties.Resources._2;
            this.pictureBoxBoxDado2_02.Location = new System.Drawing.Point(254, 479);
            this.pictureBoxBoxDado2_02.Name = "pictureBoxBoxDado2_02";
            this.pictureBoxBoxDado2_02.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxBoxDado2_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoxDado2_02.TabIndex = 11;
            this.pictureBoxBoxDado2_02.TabStop = false;
            // 
            // pictureBoxDado2_01
            // 
            this.pictureBoxDado2_01.Image = global::SimulacionEstadistica.Properties.Resources._1;
            this.pictureBoxDado2_01.Location = new System.Drawing.Point(58, 479);
            this.pictureBoxDado2_01.Name = "pictureBoxDado2_01";
            this.pictureBoxDado2_01.Size = new System.Drawing.Size(181, 169);
            this.pictureBoxDado2_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDado2_01.TabIndex = 10;
            this.pictureBoxDado2_01.TabStop = false;
            // 
            // textBoxNVecesQVaAGirar
            // 
            this.textBoxNVecesQVaAGirar.Location = new System.Drawing.Point(1457, 106);
            this.textBoxNVecesQVaAGirar.Name = "textBoxNVecesQVaAGirar";
            this.textBoxNVecesQVaAGirar.Size = new System.Drawing.Size(100, 26);
            this.textBoxNVecesQVaAGirar.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1292, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Elige las N veces que va a girar:";
            // 
            // labelNumeroDeTiros
            // 
            this.labelNumeroDeTiros.AutoSize = true;
            this.labelNumeroDeTiros.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeTiros.Location = new System.Drawing.Point(38, 204);
            this.labelNumeroDeTiros.Name = "labelNumeroDeTiros";
            this.labelNumeroDeTiros.Size = new System.Drawing.Size(61, 30);
            this.labelNumeroDeTiros.TabIndex = 18;
            this.labelNumeroDeTiros.Text = "......";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1277, 702);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(454, 217);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1082, 136);
            this.label3.TabIndex = 20;
            this.label3.Text = "SIMULACIÓN DE FRECUENCIA RELATIVA \r\nY ABSOLUTA EN LA SUMA DE DOS DADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimulacionEstadistica.Properties.Resources.FondoEst;
            this.ClientSize = new System.Drawing.Size(1743, 948);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.labelNumeroDeTiros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNVecesQVaAGirar);
            this.Controls.Add(this.pictureBoxBoxDado2_06);
            this.Controls.Add(this.pictureBoxBoxDado2_05);
            this.Controls.Add(this.pictureBoxBoxDado2_04);
            this.Controls.Add(this.pictureBoxBoxDado2_03);
            this.Controls.Add(this.pictureBoxBoxDado2_02);
            this.Controls.Add(this.pictureBoxDado2_01);
            this.Controls.Add(this.pictureBoxDado1_06);
            this.Controls.Add(this.pictureBoxDado1_05);
            this.Controls.Add(this.pictureBoxDado1_04);
            this.Controls.Add(this.pictureBoxDado1_03);
            this.Controls.Add(this.pictureBoxDado1_02);
            this.Controls.Add(this.pictureBoxDado1_01);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotonGirarDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoxDado2_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxBotonGirarDados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBoxDado1_01;
        private System.Windows.Forms.PictureBox pictureBoxDado1_02;
        private System.Windows.Forms.PictureBox pictureBoxDado1_03;
        private System.Windows.Forms.PictureBox pictureBoxDado1_04;
        private System.Windows.Forms.PictureBox pictureBoxDado1_05;
        private System.Windows.Forms.PictureBox pictureBoxDado1_06;
        private System.Windows.Forms.PictureBox pictureBoxBoxDado2_06;
        private System.Windows.Forms.PictureBox pictureBoxBoxDado2_05;
        private System.Windows.Forms.PictureBox pictureBoxBoxDado2_04;
        private System.Windows.Forms.PictureBox pictureBoxBoxDado2_03;
        private System.Windows.Forms.PictureBox pictureBoxBoxDado2_02;
        private System.Windows.Forms.PictureBox pictureBoxDado2_01;
        private System.Windows.Forms.TextBox textBoxNVecesQVaAGirar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumeroDeTiros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
    }
}

