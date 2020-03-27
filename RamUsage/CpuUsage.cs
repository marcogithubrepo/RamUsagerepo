using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management.Instrumentation;



namespace RamUsage
{

    class CpuUsage : BaseUsage
    {
        private PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter tempCount = new PerformanceCounter("Thermal Zone Information", "Temperature", @"\_TZ.THRM");

        private bool _isTemperatureRead;
        int a;
        private string _PhysicalCore;
        private int _CoresCount;
        private int _LogicalCoresCount;
        private string _Temperature;

        //Posso modificare il valore solo dalla classe stessa non fuori
        public bool isTemperatureRead
        {
            get { return _isTemperatureRead; }
            private set { _isTemperatureRead = value; }
        }

        public string PhysicalCore
        {
            get { return _PhysicalCore; }
            private set { _PhysicalCore = value; }
        }

        public int CoresCount
        {
            get { return _CoresCount; }
            private set { _CoresCount = value; }
        }

        public int LogicalCoresCount
        {
            get { return Environment.ProcessorCount; }
            private set { _LogicalCoresCount = value; }
        }


        public string Temperature
        {
            get { return _Temperature; }
            private set { _Temperature = value; }
        }


        public CpuUsage()
        {
            _isTemperatureRead = true;
            _PhysicalCore = get_physicalprocessor();
            _CoresCount = get_Cores();
        }

        public string get_physicalprocessor()
        {
            try
            {
                foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
                {
                    Console.WriteLine("Number Of Physical Processors: {0} ", item["NumberOfProcessors"]);
                    this.PhysicalCore = item["NumberOfProcessors"].ToString();
                }

            }
            catch (InvalidOperationException e)
            {

                this.PhysicalCore = "0";
                Console.WriteLine(e);
            }

            return this.PhysicalCore;
        }

        public int get_Cores()
        {
            try
            {

                int coreCount = 0;
                foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
                {
                    coreCount += int.Parse(item["NumberOfCores"].ToString());
                }
                this.CoresCount = coreCount;
            }
            catch (InvalidOperationException e)
            {
                this.CoresCount = 0;
                Console.WriteLine(e);
            }

            return CoresCount;
        }

        public override float get_usedPercentage()
        {

            try
            {
                this.theCPUCounter.NextValue();
                System.Threading.Thread.Sleep(50);
                UsedPercentage = theCPUCounter.NextValue();

            }
            catch (InvalidOperationException e)
            {
                UsedPercentage = 0.00F;
                Console.WriteLine(e);
            }

            return UsedPercentage;
        }

        public string get_temperatureFunct()
        {
            try
            {
                Temperature = ((int)(tempCount.NextValue() - 273.15f)).ToString();
            }
            catch (InvalidOperationException e)
            {
                isTemperatureRead = false;
                Temperature = "ND"; 
                Console.WriteLine(e);
            }
            //in ogni caso
            //finally {
            //    Temperature = 0.00F;      
            //}

            return Temperature;
        }


    }
}
