﻿namespace lab1._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_value = new System.Windows.Forms.Label();
            this.m_value = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 100D;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.Maximum = 65D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -5D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Signal copy";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(581, 348);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 759);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "M =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 808);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "D =";
            // 
            // d_value
            // 
            this.d_value.AutoSize = true;
            this.d_value.Location = new System.Drawing.Point(135, 808);
            this.d_value.Name = "d_value";
            this.d_value.Size = new System.Drawing.Size(31, 17);
            this.d_value.TabIndex = 1;
            this.d_value.Text = "N/A";
            // 
            // m_value
            // 
            this.m_value.AutoSize = true;
            this.m_value.Location = new System.Drawing.Point(135, 759);
            this.m_value.Name = "m_value";
            this.m_value.Size = new System.Drawing.Size(31, 17);
            this.m_value.TabIndex = 1;
            this.m_value.Text = "N/A";
            // 
            // chart2
            // 
            chartArea2.AxisX.Interval = 100D;
            chartArea2.AxisX.IsMarksNextToAxis = false;
            chartArea2.AxisX.Maximum = 65D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 200D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(586, 12);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Complexity";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Complexity (list)";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(632, 348);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // chart3
            // 
            chartArea3.AxisX.Interval = 100D;
            chartArea3.AxisX.IsMarksNextToAxis = false;
            chartArea3.AxisX.Maximum = 33D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.AxisY.Minimum = -1D;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(586, 366);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "cor";
            series5.YValuesPerPoint = 2;
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(581, 348);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 898);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "N/A";
            // 
            // chart4
            // 
            chartArea4.AxisX.Interval = 100D;
            chartArea4.AxisX.IsMarksNextToAxis = false;
            chartArea4.AxisX.Maximum = 33D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.AxisY.Minimum = -1D;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(12, 366);
            this.chart4.Name = "chart4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "autocor";
            series6.YValuesPerPoint = 2;
            this.chart4.Series.Add(series6);
            this.chart4.Size = new System.Drawing.Size(581, 348);
            this.chart4.TabIndex = 0;
            this.chart4.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 892);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d_value);
            this.Controls.Add(this.m_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label d_value;
        private System.Windows.Forms.Label m_value;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

