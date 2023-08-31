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

        public Fish() { }

        public Fish(string? name, int? age, char? gender, int? energy, int? price, int? maxMealQuantity, int? currMealQuantity, bool isVertebrate)
    : base(name, age, gender, energy, price, maxMealQuantity, currMealQuantity)
=> IsVertebrate = isVertebrate;

        public override void MakeSound() => Console.WriteLine("bul bul");

        public override string ToString() => base.ToString() + $"{(IsVertebrate ? "Vertebrate" : "Invertebrate")}\n";
    }
}
