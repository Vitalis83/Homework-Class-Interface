using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto.Interfaces
{
    internal interface IEngine
    {
        string EngineName { get; set; }
        int EngineMaxSpeed { get; set; }
    }
}
