﻿namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnDisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea5.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea5);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.sysChart.Legends.Add(legend5);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.sysChart.Series.Add(series5);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(557, 275);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(115, 40);
            this.btnCpu.TabIndex = 1;
            this.btnCpu.Text = "CPU (ON)";
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.ButtonCpuClick);
            // 
            // btnMemory
            // 
            this.btnMemory.Location = new System.Drawing.Point(557, 321);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(115, 40);
            this.btnMemory.TabIndex = 2;
            this.btnMemory.Text = "Memory (Off)";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.ButtonMemoryClick);
            // 
            // btnDisk
            // 
            this.btnDisk.Location = new System.Drawing.Point(557, 367);
            this.btnDisk.Name = "btnDisk";
            this.btnDisk.Size = new System.Drawing.Size(115, 40);
            this.btnDisk.TabIndex = 3;
            this.btnDisk.Text = "Disk (Off)";
            this.btnDisk.UseVisualStyleBackColor = true;
            this.btnDisk.Click += new System.EventHandler(this.ButtonDiskClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.btnDisk);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnDisk;
    }
}

