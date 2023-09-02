using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___petshop
{
    internal class Dog : Animal
    {
        public string? PawColor { get; set; } // pence rengi

        public Dog() { MaxMealQuantity = 40; }

        public Dog(string? name, int? age, char? gender, int? price, string? pawColor)
    : base(name, age, gender, price)
        {
            PawColor = pawColor;
            MaxMealQuantity = 40;
        }

        public override void MakeSound() => Console.WriteLine("\nWoof woof");

        public override string ToString() => base.ToString() + $"Paw color: {PawColor}\n";
    }
}
