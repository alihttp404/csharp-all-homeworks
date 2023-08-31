using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _3___petshop
{
    internal class PetShop
    {
        public string? Name { get; set; }
        public string? Location { get; set; }

        private Cat[]? cats;
        public Cat[]? Cats { get => cats; set => cats = value; }

        private Dog[]? dogs;
        public Dog[]? Dogs { get => dogs; set => dogs = value; }

        private Fish[]? fishes;
        public Fish[]? Fishes { get => fishes; set => fishes = value; }

        public PetShop() { }

        public PetShop(string? name, string? location)
        {
            Name = name;
            Location = location;
        }

        public PetShop(string? name, string? location, Cat[]? cats, Dog[]? dogs, Fish[]? fishes)
        {
            Name = name;
            Location = location;
            Cats = cats;
            Dogs = dogs;
            Fishes = fishes;
        }

        public void AddCat(ref Cat cat) 
        {
            Array.Resize(ref cats, (cats.Length + 1));
            cats[cats.Length - 1] = cat;
        }

        public void AddDog(ref Dog dog)
        {
            Array.Resize(ref dogs, (dogs.Length + 1));
            dogs[dogs.Length - 1] = dog;
        }

        public void AddFish(ref Fish fish)
        {
            Array.Resize(ref fishes, (fishes.Length + 1));
            fishes[fishes.Length - 1] = fish;
        }
    }
}
