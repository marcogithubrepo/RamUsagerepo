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
    
    class BaseUsage
    {
        private float _InstalledMB;
        private float _UsedPercentage;
        private float _UsedMB;

        //Posso modificare il valore solo da classi derivate non fuori
        public float InstalledMB
        {
            get { return _InstalledMB; }
            protected set { _InstalledMB = value; }
        }

        public float UsedPercentage
        {
            get { return _UsedPercentage; }
            protected set { _UsedPercentage = value; }
        }

        public float UsedMB
        {
            get { return _UsedMB; }
            protected set { _UsedMB = value; }
        }

        public BaseUsage()
        {
            InstalledMB = 0.00F;
            UsedPercentage = 0.00F;
            UsedMB = 0.00F;
        }

        public virtual float get_totalMB() { return 0.00F; }
        public virtual float get_usedMB() { return 0.00F; }
        public virtual float get_usedPercentage() { return 0.00F; }



    }
}
