namespace RamUsage
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.listViewRam = new System.Windows.Forms.ListView();
            this.lblRamInfo = new System.Windows.Forms.Label();
            this.listViewCpu = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartRAMPerc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCPUPerc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAMPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPUPerc)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ram used %:";
            // 
            // listViewRam
            // 
            this.listViewRam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listViewRam.HideSelection = false;
            this.listViewRam.Location = new System.Drawing.Point(543, 54);
            this.listViewRam.Name = "listViewRam";
            this.listViewRam.Size = new System.Drawing.Size(223, 107);
            this.listViewRam.TabIndex = 7;
            this.listViewRam.UseCompatibleStateImageBehavior = false;
            // 
            // lblRamInfo
            // 
            this.lblRamInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRamInfo.AutoSize = true;
            this.lblRamInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamInfo.Location = new System.Drawing.Point(607, 20);
            this.lblRamInfo.Name = "lblRamInfo";
            this.lblRamInfo.Size = new System.Drawing.Size(95, 22);
            this.lblRamInfo.TabIndex = 8;
            this.lblRamInfo.Text = "RAM Info:";
            // 
            // listViewCpu
            // 
            this.listViewCpu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listViewCpu.HideSelection = false;
            this.listViewCpu.Location = new System.Drawing.Point(543, 280);
            this.listViewCpu.Name = "listViewCpu";
            this.listViewCpu.Size = new System.Drawing.Size(223, 107);
            this.listViewCpu.TabIndex = 10;
            this.listViewCpu.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPU Info:";
            // 
            // chartRAMPerc
            // 
            this.chartRAMPerc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            this.chartRAMPerc.ChartAreas.Add(chartArea1);
            this.chartRAMPerc.Location = new System.Drawing.Point(10, 9);
            this.chartRAMPerc.MinimumSize = new System.Drawing.Size(521, 100);
            this.chartRAMPerc.Name = "chartRAMPerc";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartRAMPerc.Series.Add(series1);
            this.chartRAMPerc.Size = new System.Drawing.Size(521, 197);
            this.chartRAMPerc.TabIndex = 10;
            this.chartRAMPerc.Text = "chart1";
            // 
            // chartCPUPerc
            // 
            this.chartCPUPerc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            this.chartCPUPerc.ChartAreas.Add(chartArea2);
            this.chartCPUPerc.Location = new System.Drawing.Point(10, 235);
            this.chartCPUPerc.MinimumSize = new System.Drawing.Size(521, 100);
            this.chartCPUPerc.Name = "chartCPUPerc";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartCPUPerc.Series.Add(series2);
            this.chartCPUPerc.Size = new System.Drawing.Size(521, 197);
            this.chartCPUPerc.TabIndex = 12;
            this.chartCPUPerc.Text = "chartcpu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.chartCPUPerc);
            this.Controls.Add(this.chartRAMPerc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCpu);
            this.Controls.Add(this.lblRamInfo);
            this.Controls.Add(this.listViewRam);
            this.Name = "Form1";
            this.Text = "Ram Usage";
            ((System.ComponentModel.ISupportInitialize)(this.chartRAMPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPUPerc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RamUsage RamUse;
        private CpuUsage CpuUse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRam;
        private System.Windows.Forms.Label lblRamInfo;
        private System.Windows.Forms.ListView listViewCpu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRAMPerc;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCPUPerc;
    }
}

