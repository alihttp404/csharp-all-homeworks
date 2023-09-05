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
        public BankCatrd Card { get; set; }

        public User() { }
        public User(string name, string surname) { Name = name; Surname = surname; }
        public User(string name, string surname, BankCatrd bk) : this(name, surname) { Card = bk; }
    }
}
