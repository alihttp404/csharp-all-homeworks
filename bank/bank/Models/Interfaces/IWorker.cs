using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank.Models.Classes;

namespace bank.Models.Interfaces
{
    internal interface IWorker
    {
        string Position { get; set; }
        int Salary { get; set; }

        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        Operation[] Operations { get; set; }

        void AddOperation();
    }
}
