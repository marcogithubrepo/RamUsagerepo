using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamUsage
{
    public partial class Form1 : Form
    {
        //no property used only inside the class
        private float[] ramarray = new float[100];
        private float[] cpuarray = new float[100];
        private float[] cputemparray = new float[100];
        private int first100Ram = 0;
        private int first100Cpu = 0;
  
        public Form1()
        {
            for (int i = 0; i < ramarray.Length; i++)
            {
                ramarray[i] = 0.00F;
            }

            InitializeComponent();
          
            this.RamUse = new RamUsage();
            this.CpuUse = new CpuUsage();
          
            //Set RamoPercChart Type
            this.chartRAMPerc.ChartAreas[0].AxisY.ScaleView.Zoom(0, 100);
            this.chartRAMPerc.ChartAreas[0].AxisY.Title = "Used RAM %";
            this.chartRAMPerc.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);
            this.chartRAMPerc.ChartAreas[0].AxisX.Title = "Time (sec)";
            this.chartRAMPerc.Series[0].Color = Color.Blue;
            this.chartRAMPerc.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chartRAMPerc.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chartRAMPerc.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //Set CPUPercChart Type
            this.chartCPUPerc.ChartAreas[0].AxisY.ScaleView.Zoom(0, 100);
            this.chartCPUPerc.ChartAreas[0].AxisY.Title = "Used CPU %";
            this.chartCPUPerc.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);
            this.chartCPUPerc.ChartAreas[0].AxisX.Title = "Time (sec)";
            this.chartCPUPerc.Series[0].Color = Color.Red;
            this.chartCPUPerc.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chartCPUPerc.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chartCPUPerc.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            //listview setting
            this.listViewRam.View = View.Details;
            this.listViewRam.Columns.Add("Column1Name");
            this.listViewRam.Columns.Add("Column2Name");
            this.listViewRam.Columns[0].Width = 100;
            this.listViewRam.GridLines = true;
            this.listViewRam.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            //Write the total RAM in MB on listview
            float totalRAM = RamUse.get_totalMB();
            this.listViewRam.Items.Add(new ListViewItem(new string[] { "Total Ram (MB): ", totalRAM.ToString("N2") + " MB" }));
            this.listViewRam.Items.Add(new ListViewItem(new string[] { "Used Ram (MB): ",   "0.00 MB" }));
            this.listViewRam.Items.Add(new ListViewItem(new string[] { "Used Ram (%): ", "0.00 %" }));

            //listviewCPU setting
            this.listViewCpu.View = View.Details;
            this.listViewCpu.Columns.Add("Column1Name");
            this.listViewCpu.Columns.Add("Column2Name");
            this.listViewCpu.Columns[0].Width = 100;
            this.listViewCpu.GridLines = true;
            this.listViewCpu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            //Write the Cpu static info
            this.listViewCpu.Items.Add(new ListViewItem(new string[] { "Physical Core: ", CpuUse.get_physicalprocessor().ToString() }));
            this.listViewCpu.Items.Add(new ListViewItem(new string[] { "Cores: ", CpuUse.get_Cores().ToString() }));
            this.listViewCpu.Items.Add(new ListViewItem(new string[] { "Logical Cores: ", CpuUse.LogicalCoresCount.ToString() }));
            this.listViewCpu.Items.Add(new ListViewItem(new string[] { "Used Cpu (%): ", "0.00 %" }));
            this.listViewCpu.Items.Add(new ListViewItem(new string[] { "Temperature (°C): ", "0" }));

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateChartRam();

            CpuUse.get_usedPercentage();

            if (CpuUse.isTemperatureRead)
             CpuUse.get_temperatureFunct(); 
                

            UpdateChartCpu(CpuUse.UsedPercentage, CpuUse.Temperature);
        }


        private void UpdateChartRam()
        {
            foreach (var series in chartRAMPerc.Series)
            {
                series.Points.Clear();
            }

            if (RamUse == null)
                return;


            //Write the ram used in MB on the listwview
            float ramMB = RamUse.get_usedMB();
            foreach (ListViewItem item in this.listViewRam.Items)
            {
                if (item.Index == 1)
                    item.SubItems[1].Text = ramMB.ToString("N2") + " MB";
            }


            //Write the ram used in percentage on the listview
            float ram = RamUse.get_usedPercentage();
         

            foreach (ListViewItem item in this.listViewRam.Items)
            {
                if (item.Index == 2)
                    item.SubItems[1].Text = ram.ToString("N2") + " %";
            }


            //write RAM Array first 100 steps
            if (first100Ram < 100)
            {
                ramarray[first100Ram] = ram;

                for (int i = 0; i < ramarray.Length; i++)
                {
                    chartRAMPerc.Series[0].Points.AddY(ramarray[i]); //ramarray[i];
                }

                first100Ram++;
            } //write RAM Array After 100 steps
            else
            {
                ramarray[99] = ram;

                for (int i = 0; i < ramarray.Length - 1; i++)
                {
                    ramarray[i] = ramarray[i + 1];
                }

                for (int i = 0; i < ramarray.Length; i++)
                {
                    chartRAMPerc.Series[0].Points.AddY(ramarray[i]);
                }
            }

        }

        public bool UpdateChartCpu(float usedpercentage, string temperature )
        {
          
            foreach (var series in chartCPUPerc.Series)
            {
                series.Points.Clear();
            }

            if (CpuUse == null)
                return false;

            foreach (ListViewItem item in this.listViewCpu.Items)
            {
                if (item.Index == 3)
                    item.SubItems[1].Text = usedpercentage.ToString("N2") + " %";
                if (item.Index == 4)
                    item.SubItems[1].Text = temperature + " °C";   
            }

           
            //write RAM Array first 100 steps
            if (first100Cpu < 100)
            {
                cpuarray[first100Cpu] = usedpercentage;

                for (int i = 0; i < cpuarray.Length; i++)
                {
                    chartCPUPerc.Series[0].Points.AddY(cpuarray[i]); //ramarray[i];
                }

                first100Cpu++;
            } //write RAM Array After 100 steps
            else
            {
                cpuarray[99] = usedpercentage;

                for (int i = 0; i < cpuarray.Length - 1; i++)
                {
                    cpuarray[i] = cpuarray[i + 1];
                }

                for (int i = 0; i < cpuarray.Length; i++)
                {
                    chartCPUPerc.Series[0].Points.AddY(cpuarray[i]);
                }
            }

            return true;

        }

    }
}
