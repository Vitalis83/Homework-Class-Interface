﻿using HomeworkClassAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto
{
    internal class CarClass : ICar
    {
        public string Name { get; set; }
        public IEngine engineType { get; set; }
        public ITransmission transType { get; set; }

        
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
