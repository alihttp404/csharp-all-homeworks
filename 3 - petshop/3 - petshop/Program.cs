using _3___petshop;

PetShop petShop = new PetShop("Heyvanlar 999", "Babek Prospekti 139C");

Cat[] cats = new Cat[]
{
    new Cat("Mestan", 3, 'F', 170, "blue"),
    new Cat("Canavar", 10, 'M', 50, "gray"),
    new Cat("Qarabala", 2, 'F', 200, "black"),
    new Cat("Messi", 6, 'M', 140, "blue")
};
petShop.Cats = cats;

Dog[] dogs = new Dog[]
{
    new Dog("Toplan", 3, 'F', 240, "brown"),
    new Dog("Alabas", 6, 'F', 160, "black"),
    new Dog("Maxi", 8, 'M', 130, "pink"),
    new Dog("Simba", 3, 'M', 240, "gray")
};
petShop.Dogs = dogs;

Fish[] fishes = new Fish[]
{
    new Fish("Land Cruiser", 1, 'M', 10, true),
    new Fish("RAV4", 2, 'M', 5, false),
    new Fish("Prius", 2, 'M', 5, true),
    new Fish("Camry", 3, 'M', 3, true)
};
petShop.Fishes = fishes;

Console.WriteLine(petShop);
Console.WriteLine("\n\n\n");

petShop.RemoveCatByNickname("Mestan");

Console.WriteLine(petShop);
