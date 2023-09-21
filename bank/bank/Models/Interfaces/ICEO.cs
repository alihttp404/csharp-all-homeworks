using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Interfaces
{
    internal interface ICEO
    {
        void Control() { Console.WriteLine("control"); }
        void MakeMeeting() { Console.WriteLine("MEEEETING"); }
        void DecreasePercentage(double percentage);
    }
}
