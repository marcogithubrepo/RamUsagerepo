using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RamUsage
{
    class Temperature
    {
        public double CurrentValue { get; set; }
        public string InstanceName { get; set; }
        PerformanceCounter tempCount = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public Temperature()
        {
            float Temp = 0.00F;
            //this.tempCount.NextValue();

            Temp = this.tempCount.NextValue();
        }



    }
}
