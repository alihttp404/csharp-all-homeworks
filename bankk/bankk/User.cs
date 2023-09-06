using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bankk
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }
        public BankCatrd Card { get; set; }
        public List<string> Operations;

        public User()
        {
            Name = "NULL";
            Surname = "NULL";
            PIN = "NULL";
        }

        public User(string name, string surname, string pin)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
            Card = new BankCatrd();
            Operations = new List<string>();
        }

        public void ShowOperations() { if (Operations.Count != 0) foreach (string op in Operations) Console.WriteLine(op); Console.ReadKey(true); }
    }
}
