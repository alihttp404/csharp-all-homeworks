using bank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Classes
{
    internal class CEO : Person, IWorker, IAdmin, ICEO
    {
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime StartTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Operation[] Operations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddOperation() { }
        public void DecreasePercentage(double percentage) { }
        public void Organize() { }
    }
}
