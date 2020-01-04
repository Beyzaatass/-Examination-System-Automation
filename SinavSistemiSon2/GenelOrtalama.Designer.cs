namespace SinavSistemiSon
{
    partial class GenelOrtalama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenelOrtalama));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SoruKaydetCikisButon = new System.Windows.Forms.PictureBox();
            this.GenelOrtalamaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SoruKaydetCikisButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenelOrtalamaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SoruKaydetCikisButon
            // 
            this.SoruKaydetCikisButon.BackColor = System.Drawing.Color.Transparent;
            this.SoruKaydetCikisButon.Image = ((System.Drawing.Image)(resources.GetObject("SoruKaydetCikisButon.Image")));
            this.SoruKaydetCikisButon.Location = new System.Drawing.Point(526, 3);
            this.SoruKaydetCikisButon.Name = "SoruKaydetCikisButon";
            this.SoruKaydetCikisButon.Size = new System.Drawing.Size(28, 22);
            this.SoruKaydetCikisButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoruKaydetCikisButon.TabIndex = 5;
            this.SoruKaydetCikisButon.TabStop = false;
            this.SoruKaydetCikisButon.Click += new System.EventHandler(this.SoruKaydetCikisButon_Click);
            // 
            // GenelOrtalamaChart
            // 
            this.GenelOrtalamaChart.BackColor = System.Drawing.Color.PeachPuff;
            this.GenelOrtalamaChart.BorderlineColor = System.Drawing.Color.PeachPuff;
            chartArea1.Name = "ChartArea1";
            this.GenelOrtalamaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GenelOrtalamaChart.Legends.Add(legend1);
            this.GenelOrtalamaChart.Location = new System.Drawing.Point(28, 46);
            this.GenelOrtalamaChart.Name = "GenelOrtalamaChart";
            this.GenelOrtalamaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.SmallConfetti;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "Sinav";
            this.GenelOrtalamaChart.Series.Add(series1);
            this.GenelOrtalamaChart.Size = new System.Drawing.Size(526, 358);
            this.GenelOrtalamaChart.TabIndex = 6;
            this.GenelOrtalamaChart.Text = "chart1";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(198, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 24);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Sınav Notlarınız";
            // 
            // GenelOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.GenelOrtalamaChart);
            this.Controls.Add(this.SoruKaydetCikisButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenelOrtalama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenelOrtalama";
            this.Load += new System.EventHandler(this.GenelOrtalama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoruKaydetCikisButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenelOrtalamaChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox SoruKaydetCikisButon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenelOrtalamaChart;
    }
}