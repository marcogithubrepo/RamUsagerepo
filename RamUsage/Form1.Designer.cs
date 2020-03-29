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
            this.listViewCpu = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRAMPerc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRamInfo = new System.Windows.Forms.Label();
            this.chartCPUPerc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.listViewRam.Location = new System.Drawing.Point(566, 102);
            this.listViewRam.Name = "listViewRam";
            this.listViewRam.Size = new System.Drawing.Size(207, 110);
            this.listViewRam.TabIndex = 7;
            this.listViewRam.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCpu
            // 
            this.listViewCpu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listViewCpu.HideSelection = false;
            this.listViewCpu.Location = new System.Drawing.Point(566, 366);
            this.listViewCpu.Name = "listViewCpu";
            this.listViewCpu.Size = new System.Drawing.Size(208, 110);
            this.listViewCpu.TabIndex = 10;
            this.listViewCpu.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Siemens Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(3, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPU Chart:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.89441F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.10559F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartRAMPerc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRamInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewRam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewCpu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartCPUPerc, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 528);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Siemens Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(566, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPU Info:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Siemens Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(566, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "RAM info:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartRAMPerc
            // 
            this.chartRAMPerc.BackColor = System.Drawing.SystemColors.Control;
            this.chartRAMPerc.BackSecondaryColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartRAMPerc.ChartAreas.Add(chartArea1);
            this.chartRAMPerc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRAMPerc.Location = new System.Drawing.Point(3, 53);
            this.chartRAMPerc.MinimumSize = new System.Drawing.Size(520, 150);
            this.chartRAMPerc.Name = "chartRAMPerc";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartRAMPerc.Series.Add(series1);
            this.chartRAMPerc.Size = new System.Drawing.Size(557, 208);
            this.chartRAMPerc.TabIndex = 11;
            this.chartRAMPerc.Text = "chart1";
            // 
            // lblRamInfo
            // 
            this.lblRamInfo.AutoSize = true;
            this.lblRamInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRamInfo.Font = new System.Drawing.Font("Siemens Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRamInfo.Location = new System.Drawing.Point(3, 27);
            this.lblRamInfo.Name = "lblRamInfo";
            this.lblRamInfo.Size = new System.Drawing.Size(557, 23);
            this.lblRamInfo.TabIndex = 8;
            this.lblRamInfo.Text = "RAM Chart:";
            this.lblRamInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartCPUPerc
            // 
            this.chartCPUPerc.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartCPUPerc.ChartAreas.Add(chartArea2);
            this.chartCPUPerc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCPUPerc.Location = new System.Drawing.Point(3, 317);
            this.chartCPUPerc.MinimumSize = new System.Drawing.Size(520, 150);
            this.chartCPUPerc.Name = "chartCPUPerc";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartCPUPerc.Series.Add(series2);
            this.chartCPUPerc.Size = new System.Drawing.Size(557, 208);
            this.chartCPUPerc.TabIndex = 13;
            this.chartCPUPerc.Text = "chartcpu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Ram Usage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAMPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPUPerc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RamUsage RamUse;
        private CpuUsage CpuUse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRam;
        private System.Windows.Forms.ListView listViewCpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRAMPerc;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCPUPerc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRamInfo;
        private System.Windows.Forms.Label label4;
    }
}

