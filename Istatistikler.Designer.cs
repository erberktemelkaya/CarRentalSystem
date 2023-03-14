namespace ArabaKiralama
{
    partial class Istatistikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_araba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_araba)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_araba
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_araba.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_araba.Legends.Add(legend1);
            this.chart_araba.Location = new System.Drawing.Point(12, 12);
            this.chart_araba.Name = "chart_araba";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Şehir";
            this.chart_araba.Series.Add(series1);
            this.chart_araba.Size = new System.Drawing.Size(776, 426);
            this.chart_araba.TabIndex = 0;
            this.chart_araba.Text = "chart1";
            // 
            // Istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart_araba);
            this.Name = "Istatistikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istatistikler";
            this.Load += new System.EventHandler(this.Istatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_araba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_araba;
    }
}