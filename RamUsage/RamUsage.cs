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
    
    class RamUsage : BaseUsage
    {
       private PerformanceCounter theMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        public RamUsage()
        {

        }
     

        public override float get_usedMB()
        {

            try
            {
                float ramUsage = 0.00F;

                this.theMemCounter.NextValue();
                ramUsage = this.theMemCounter.NextValue();
                UsedMB = this.InstalledMB - ramUsage / 1024;
            }
            catch (InvalidOperationException e)
            {
                UsedMB = 0.00F;
                Console.WriteLine(e);
            }
            
            return UsedMB;
        }

        public override float get_usedPercentage()
        {

            try
            {
                float ramUsage = 0.00F;

                ramUsage = this.get_usedMB();
                UsedPercentage = (float)((ramUsage / (InstalledMB)) * 100.0);

            }
            catch (InvalidOperationException e)
            {
                UsedPercentage = 0.00F;
                Console.WriteLine(e);
            }

            return UsedPercentage;
       
        }

        public override float get_totalMB()
        {

            try
            {
                InstalledMB = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
                InstalledMB = (InstalledMB / (1024 * 1024 * 1024));
            }
            catch (InvalidOperationException e)
            {
                InstalledMB = 0.00F;
                Console.WriteLine(e);
            }

            return InstalledMB;
            
        }

    }
}
