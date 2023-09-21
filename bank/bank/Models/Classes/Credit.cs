using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Classes
{
    internal class Credit
    {
        public Guid ID { get; set; }
        public Client Client { get; set; }

        public long Amount { get; set; }
        public double Decimal { get; set; }

        public int Months { get; set; }

        public void CalculatePercent() { }
        public void Payment() { }
    }
}
