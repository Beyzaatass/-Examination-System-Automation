namespace SinavSistemiSon
{
    partial class EskiSinavlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EskiSinavlar));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SoruKaydetCikisButon = new System.Windows.Forms.PictureBox();
            this.IstatistikComboBox = new System.Windows.Forms.ComboBox();
            this.SınavDogruChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SoruKaydetCikisButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SınavDogruChart)).BeginInit();
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
            this.SoruKaydetCikisButon.Location = new System.Drawing.Point(681, 2);
            this.SoruKaydetCikisButon.Name = "SoruKaydetCikisButon";
            this.SoruKaydetCikisButon.Size = new System.Drawing.Size(28, 22);
            this.SoruKaydetCikisButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoruKaydetCikisButon.TabIndex = 4;
            this.SoruKaydetCikisButon.TabStop = false;
            this.SoruKaydetCikisButon.Click += new System.EventHandler(this.SoruKaydetCikisButon_Click);
            // 
            // IstatistikComboBox
            // 
            this.IstatistikComboBox.FormattingEnabled = true;
            this.IstatistikComboBox.Location = new System.Drawing.Point(298, 12);
            this.IstatistikComboBox.Name = "IstatistikComboBox";
            this.IstatistikComboBox.Size = new System.Drawing.Size(121, 21);
            this.IstatistikComboBox.TabIndex = 5;
            // 
            // SınavDogruChart
            // 
            this.SınavDogruChart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.SınavDogruChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5.479452F;
            legend1.Position.Width = 12.11656F;
            legend1.Position.X = 84.88344F;
            legend1.Position.Y = 3F;
            this.SınavDogruChart.Legends.Add(legend1);
            this.SınavDogruChart.Location = new System.Drawing.Point(22, 73);
            this.SınavDogruChart.Name = "SınavDogruChart";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Sinav";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.SınavDogruChart.Series.Add(series1);
            this.SınavDogruChart.Size = new System.Drawing.Size(653, 439);
            this.SınavDogruChart.TabIndex = 6;
            this.SınavDogruChart.Text = "chart1";
            // 
            // EskiSinavlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 553);
            this.Controls.Add(this.SınavDogruChart);
            this.Controls.Add(this.IstatistikComboBox);
            this.Controls.Add(this.SoruKaydetCikisButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EskiSinavlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EskiSinavlar";
            this.Load += new System.EventHandler(this.EskiSinavlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoruKaydetCikisButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SınavDogruChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox SoruKaydetCikisButon;
        private System.Windows.Forms.ComboBox IstatistikComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart SınavDogruChart;
    }
}