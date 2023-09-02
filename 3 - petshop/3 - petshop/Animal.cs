using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _3___petshop
{
    internal abstract class Animal
    {
        private Guid id;
        public Guid Id { get => id; }

        private string? name;
        public string? Name { get => name; set => name = value?.Length >= 3 ? value : null; }

        public char? Gender { get; set; }

        private int? age;
        public int? Age { get => age; set => age = value > 0 ? value : null; }

        private int? energy = 1;
        public int? Energy { get => age; set => energy = value > 0 ? value : null; }

        private int? price;
        public int? Price { get => age; set => price = value > 0 ? value : null; }

        private int? maxMealQuantity;
        private int? MaxMealQuantity { get => maxMealQuantity; set => maxMealQuantity = value > 0 ? value : null; }

        private int? currMealQuantity;
        private int? CurrMealQuantity { get => currMealQuantity; set => currMealQuantity = value > 0 ? value : null; }

        public Animal() { }
        
        public Animal(string? name, int? age, char? gender, int? energy, int? price, int? maxMealQuantity, int? currMealQuantity) 
        {
            id = Guid.NewGuid();
            Name = name;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MaxMealQuantity = maxMealQuantity;
            CurrMealQuantity = currMealQuantity;

            CalculatePrice();
        }

        public void ZeroEnergy() // run if energy == 0
        {
            Console.Clear();
            Console.WriteLine("{0}'s energy is 0, {0} must sleep for 8 hours now", name);
            Thread.Sleep(2300);
            Sleep(8);
        }

        public void Eat(int mealQuantity)
        {
            if (mealQuantity + currMealQuantity > maxMealQuantity) return;
            if (energy == 0) { ZeroEnergy(); return; }
            currMealQuantity += mealQuantity;
            energy += Convert.ToInt32(mealQuantity / 10);
            price += mealQuantity * 2; // her defe yedikce boyuyurler deye qiymeti de artir
        }

        public void Sleep(int hours) => energy += hours;

        public void Play(int hours)
        {
            if (energy == 0) { ZeroEnergy(); return; }
            energy -= hours;
            currMealQuantity -= hours / 2;
        }

        public void CalculatePrice()
        {
            if (age <= 5) price -= age * 5;
            else if (age > 5 && age <= 10) price -= age * 6;
            else if (age > 10 && age <= 20) price -= age * 10;
            else if (age > 20) price -= age * 15;
        }

        public override string ToString()
        {
            return $@"
ID: {id}
{name}, {age}, {( Gender == 'M' ? "M" : "F")}
Price: {price}
Energy: {energy}
Hunger: {(currMealQuantity > 0 ? Convert.ToString(0) : Convert.ToString(0 - currMealQuantity))}
Max meal quantity: {maxMealQuantity}

";
        }

        public abstract void MakeSound();
    }
}
