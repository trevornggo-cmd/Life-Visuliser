using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Life_Visuliser
{
    partial class Form1
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
            this.HomeScreenCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenCht)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeScreenCht
            // 
            this.HomeScreenCht.BackColor = System.Drawing.Color.Navy;
            this.HomeScreenCht.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HomeScreenCht.BackSecondaryColor = System.Drawing.Color.White;
            this.HomeScreenCht.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.HomeScreenCht.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HomeScreenCht.Legends.Add(legend1);
            this.HomeScreenCht.Location = new System.Drawing.Point(12, 12);
            this.HomeScreenCht.Name = "HomeScreenCht";
            this.HomeScreenCht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.HomeScreenCht.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.HomeScreenCht.Series.Add(series1);
            this.HomeScreenCht.Size = new System.Drawing.Size(310, 240);
            this.HomeScreenCht.TabIndex = 0;
            this.HomeScreenCht.Text = "chart1";

            series1.Points.AddXY("stat1", 10);
            series1.Points.AddXY("stat2", 13);
            series1.Points.AddXY("stat3", 14);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeScreenCht);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenCht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HomeScreenCht;
    }
}

