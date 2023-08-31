using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3___petshop
{
    internal class Cat : Animal
    {
        public string? EyeColor { get; set; }

        public Cat() { }
        
        public Cat(string? name, int? age, char? gender, int? energy, int? price, int? maxMealQuantity, int? currMealQuantity, string? eyeColor)
            : base(name, age, gender, energy, price, maxMealQuantity, currMealQuantity)
        => EyeColor = eyeColor;

        public override void MakeSound() => Console.WriteLine("\nMeoww");

        public override string ToString() => base.ToString() + $"Eye color: {EyeColor}\n";
    }
}
