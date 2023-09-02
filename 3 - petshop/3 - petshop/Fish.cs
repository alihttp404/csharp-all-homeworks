using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___petshop
{
    internal class Fish : Animal
    {
        public bool IsVertebrate { get; set; } // onurgali ya onurgasiz baliqdi

        public Fish() { MaxMealQuantity = 5; }

        public Fish(string? name, int? age, char? gender, int? price, bool isVertebrate)
    : base(name, age, gender, price)
        {
            IsVertebrate = isVertebrate;
            MaxMealQuantity = 5;
        }

        public override void MakeSound() => Console.WriteLine("bul bul");

        public override string ToString() => base.ToString() + $"{(IsVertebrate ? "Vertebrate" : "Invertebrate")}\n";
    }
}
