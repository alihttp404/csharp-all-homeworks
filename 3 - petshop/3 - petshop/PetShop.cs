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

        public void AddAnimal(ref Animal animal) 
        {
            if (animal is Cat)
            {
                Array.Resize(ref cats, cats.Length);
                cats[cats.Length - 1] = (Cat)animal;
            }

            else if (animal is Dog)
            {
                Array.Resize(ref dogs, dogs.Length);
                dogs[dogs.Length - 1] = (Dog)animal;
            }

            else if (animal is Fish)
            {
                Array.Resize(ref fishes, fishes.Length);
                fishes[fishes.Length - 1] = (Fish)animal;
            }
        }

        public bool RemoveCatByNickname(string nickname)
        {
            bool isFound = false;
            int index = 0;
            Cat[]? newCats = new Cat[cats.Length - 1];

            for (int i = 0; i < cats.Length; i++) 
            {
                if (cats[i].Name != nickname)
                {
                    newCats[index] = cats[i];
                    index++;
                }
                else isFound = true;
            }

            cats = newCats;
            return isFound;
        }

        public bool RemoveDogByNickname(string nickname)
        {
            bool isFound = false;
            int index = 0;
            Dog[]? newDogs = new Dog[dogs.Length - 1];

            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].Name != nickname)
                {
                    newDogs[index] = dogs[i];
                    index++;
                }
                else isFound = true;
            }

            dogs = newDogs;
            return isFound;
        }

        public bool RemoveFishByNickname(string nickname)
        {
            bool isFound = false;
            int index = 0;
            Fish[]? newFishes = new Fish[fishes.Length - 1];

            for (int i = 0; i < fishes.Length; i++)
            {
                if (fishes[i].Name != nickname)
                {
                    newFishes[index] = fishes[i];
                    index++;
                }
                else isFound = true;
            }

            fishes = newFishes;
            return isFound;
        }

        public bool RemoveCatByID(string id)
        {
            bool isFound = false;
            int index = 0;
            Cat[]? newCats = new Cat[cats.Length - 1];

            for (int i = 0; i < cats.Length; i++)
            {
                if (!cats[i].Id.Equals(new Guid(id)))
                {
                    newCats[index] = cats[i];
                    index++;
                }

                else isFound = true;
            }

            return isFound;
        }

        public bool RemoveDogByID(string id)
        {
            bool isFound = false;
            int index = 0;
            Dog[]? newDogs = new Dog[dogs.Length - 1];

            for (int i = 0; i < dogs.Length; i++)
            {
                if (!dogs[i].Id.Equals(new Guid(id)))
                {
                    newDogs[index] = dogs[i];
                    index++;
                }

                else isFound = true;
            }

            return isFound;
        }

        public bool RemoveFishByID(string id)
        {
            bool isFound = false;
            int index = 0;
            Fish[]? newFishes = new Fish[fishes.Length - 1];

            for (int i = 0; i < fishes.Length; i++)
            {
                if (!fishes[i].Id.Equals(new Guid(id)))
                {
                    newFishes[index] = fishes[i];
                    index++;
                }

                else isFound = true;
            }

            return isFound;
        }

        public void ShowCats() { foreach (Cat i in cats) Console.WriteLine(i); }
        public void ShowDogs() { foreach (Dog i in dogs) Console.WriteLine(i); }
        public void ShowFishes() { foreach (Fish i in fishes) Console.WriteLine(i); }

        public override string ToString()
        {
            string shopInfo = $"{Name}\n{Location}\n\n";
            string catsInfo = "";
            string dogsInfo = "";
            string fishesInfo = "";

            foreach (Cat i in cats) catsInfo += i.ToString();
            foreach (Dog i in dogs) dogsInfo += dogsInfo;
            foreach (Fish i in fishes) fishesInfo += i.ToString();

            return shopInfo + catsInfo + dogsInfo + fishesInfo;
        }
    }
}
