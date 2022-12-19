using HomeworkClassAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto
{
    internal class TransmissionClass : ITransmission
    {
        public string TransmissionName { get; set; }

        public int MaxGear { get; set; }

        public int SpeedOnGear { get; set; }
    }
}
