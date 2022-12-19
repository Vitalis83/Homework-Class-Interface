using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassAuto.Interfaces
{
    internal interface ICar
    {
        string Name { get; set; }
        IEngine engineType { get; set; }
        ITransmission transType { get; set; }

                

        public int MaxCarSpeed();
       
       

       
    }
}
