using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Classes
{
    internal class Client : Person
    {
        public Guid ID {  get; set; }
        
        public string LiveAddress { get; set; }
        public string WorkAdress {  get; set; }
        
        public int Salary {  get; set; }
    }
}
