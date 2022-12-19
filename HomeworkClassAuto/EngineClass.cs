using HomeworkClassAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto
{
    internal class EngineClass : IEngine
    {
        public string EngineName { get; set; }
        public int EngineMaxSpeed { get; set; }
    }
}
