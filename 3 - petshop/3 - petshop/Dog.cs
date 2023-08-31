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

        public Dog() { }

        public Dog(string? name, int? age, char? gender, int? energy, int? price, int? maxMealQuantity, int? currMealQuantity, string? pawColor)
    : base(name, age, gender, energy, price, maxMealQuantity, currMealQuantity)
=> PawColor = pawColor;

        public override void MakeSound() => Console.WriteLine("\nWoof woof");

        public override string ToString() => base.ToString() + $"Paw color: {PawColor}\n";
    }
}
