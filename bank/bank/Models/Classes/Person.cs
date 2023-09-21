using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Models.Classes
{
    abstract internal class Person
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public Person() { }

        protected Person(string name, string surname, int age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
