using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto.Interfaces
{
    internal interface ITransmission
    {
        string TransmissionName { get; set; }
        int MaxGear { get; set; }          
        int SpeedOnGear { get; set; }
    }
}
