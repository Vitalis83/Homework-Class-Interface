using HomeworkClassAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto
{
    internal class CarClass : ICar
    {
        public string name { get; set; }
        public IEngine engineType { get; set; }
        public ITransmission transType { get; set; }
        
        internal CarClass(string Name, IEngine EngineType, ITransmission TransType) 
        {
            this.name = Name;
            this.engineType = EngineType;
            this.transType = TransType;

        }
        
        public int MaxCarSpeed()
        {
            if (engineType.EngineMaxSpeed > (transType.MaxGear * transType.SpeedOnGear))
            {
                return transType.MaxGear * transType.SpeedOnGear;
            }
            else
                return engineType.EngineMaxSpeed;
        }
    }
}
