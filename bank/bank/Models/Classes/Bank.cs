using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Classes
{
    internal class Bank
    {
        public string Name { get; set; }
        public long Budget { get; set; }
        public long profit { get; set; }

        public CEO CEO { get; set; }
        public Worker[] Workers { get; set; }
        public Manager[] Managers { get; set; }
        public Client[] Clients { get; set; }

        public void CalculateProfit() { }
        public void ShowClientCredit(string fullname) { }
        public void PayCredit(Client client, double Money) { }
        public void ShowAllCredit() { }
    }
}
