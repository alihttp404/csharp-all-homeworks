using Calculator;

Menu menu = new Menu(new List<string> { "Add", "Subtract", "Multiply", "Divide", "Exit" });
while (true)
{
    int option = menu.Start();

    switch (option) 
    {
        case -1:
            return;

        case 0:
            Add();
            Console.WriteLine("\nPress ESCAPE to go back");
            WaitForEscape();
            break;

        case 1:
            Subtract();
            Console.WriteLine("\nPress ESCAPE to go back");
            WaitForEscape();
            break;

        case 2:
            Multiply();
            Console.WriteLine("\nPress ESCAPE to go back");
            WaitForEscape();
            break;

        case 3:
            Divide();
            Console.WriteLine("\nPress ESCAPE to go back");
            WaitForEscape();
            break;

        case 4:
            return;
    }
}

static void Add()
{
    Console.Write("Enter num 1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter num 2: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(num1 + num2);
}

static void Subtract()
{
    Console.Write("Enter num 1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter num 2: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(num1 - num2);
}

static void Multiply()
{
    Console.Write("Enter num 1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter num 2: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(num1 * num2);
}

static void Divide()
{
    Console.Write("Enter num 1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter num 2: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}

static bool WaitForEscape()
{
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey(false);
        if (key.Key == ConsoleKey.Escape) return true;
    }
}