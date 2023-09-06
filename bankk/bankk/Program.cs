using bankk;

List<User> users = new List<User>
{
    new User("Ali", "Mammadov", "1234"),
    new User("Huseyn", "Orucov", "4321"),
    new User("Hidayer", "Hidayetov", "6789"),
    new User("User", "Userzade", "1111"),
    new User("Istifadeci", "Istifadeciyev", "0000") 
};


Menu mainMenu = new Menu(new List<string> { "Sign in", "Sign up", "Exit"});
Console.WriteLine("asdas");
User currUser = new User();

while (true)
{
    int optMainMenu = mainMenu.Start();

    if (optMainMenu == 0)
    {
        if (users.Count == 0) { Console.WriteLine("No users in database, sign up"); Thread.Sleep(2000); }

        else
        {
            Console.WriteLine("Enter PIN");
            string? pin = Console.ReadLine();
            bool found = false;

            foreach (User user in users)
            {
                if (user.PIN == pin)
                {
                    found = true;
                    currUser = user;
                    break;
                }
            }

            if (!found) { Console.WriteLine("Daxil edilmis PIN ile hesab movcud deyil"); Thread.Sleep(2000); continue; }

            else
            {
                Console.Clear();
                Menu userPanel = new Menu(new List<string> { "Balans", "Nagd pul", "Emeliyyatlar", "Exit" });

                while (true)
                {
                    int optUserPanel = userPanel.Start($"Xos gelmissiniz, {currUser.Name} {currUser.Surname}\n Asagidakilardan birini secin");

                    switch (optUserPanel)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine($"Balans: {currUser.Card.Balans} \n\nGeri qayitmaq ucun ESC\n\n");
                            Console.WriteLine(currUser.Card);
                            while (true) if (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                            break;

                        case 1:
                            Menu operations = new Menu(new List<string> { "Pul cixarma", "Balansa pul yuklemek", "Card to card", "Exit" });

                            while (true)
                            {
                                int optOperations = operations.Start();

                                switch (optOperations)
                                {
                                    case 0:
                                        Menu pulCixarma = new Menu(new List<string> { "10 AZN", "20 AZN", "50 AZN", "100 AZN", "Custom: " });

                                        while (true)
                                        {
                                            int optPulCixarma = pulCixarma.Start("ESC to exit\n");

                                            try
                                            {
                                                switch (optPulCixarma)
                                                {
                                                    case 0:
                                                        if (Utils.CheckBalance(currUser, 10))
                                                        {
                                                            currUser.Card.Balans -= 10;
                                                            currUser.Operations.Add("Balansdan 10 AZN cixildi");
                                                        }
                                                        else throw new Exception("Balans catmir");
                                                        break;

                                                    case 1:
                                                        if (Utils.CheckBalance(currUser, 20))
                                                        {
                                                            currUser.Card.Balans -= 20;
                                                            currUser.Operations.Add("Balansdan 20 AZN cixildi");
                                                        }
                                                        else throw new Exception("Balans catmir");
                                                        break;

                                                    case 2:
                                                        if (Utils.CheckBalance(currUser, 50))
                                                        {
                                                            currUser.Card.Balans -= 50;
                                                            currUser.Operations.Add("Balansdan 50 AZN cixildi");
                                                        }
                                                        else throw new Exception("Balans catmir");
                                                        break;

                                                    case 3:
                                                        if (Utils.CheckBalance(currUser, 100))
                                                        {
                                                            currUser.Card.Balans -= 100;
                                                            currUser.Operations.Add("Balansdan 100 AZN cixildi");
                                                        }
                                                        else throw new Exception("Balans catmir");
                                                        break;

                                                    case 4:
                                                        int amount;
                                                        try
                                                        {
                                                            amount = int.Parse(Console.ReadLine() ?? "0");
                                                            if (Utils.CheckBalance(currUser, amount))
                                                            {
                                                                currUser.Card.Balans -= amount;
                                                                currUser.Operations.Add($"{amount} AZN cixarildi");
                                                            }
                                                            else throw new Exception("Balans catmir");
                                                        }
                                                        catch (Exception ex) { Console.WriteLine(ex); Thread.Sleep(700); continue; }
                                                        break;
                                                }
                                                if (optPulCixarma == -1) break;
                                            }
                                            catch (Exception ex) { Console.WriteLine(ex); }
                                        }
                                        break;

                                    case 1:
                                        int amount2;
                                        Console.Write("AZN: ");

                                        try 
                                        {
                                            amount2 = int.Parse(Console.ReadLine() ?? "0");
                                            currUser.Card.Balans += amount2;
                                            currUser.Operations.Add($"{amount2} AZN balansa yuklendi"); 
                                        }

                                        catch (Exception ex) { Console.WriteLine(ex); Thread.Sleep(700); continue; }
                                        break;

                                    case 2:
                                        string toPin;
                                        bool foundToUser = false;
                                        User toUser = new User();

                                        Console.Write("TO PIN: "); toPin = Console.ReadLine() ?? "NULL";
                                        foreach (User user in users) { if (user.PIN == toPin) { foundToUser = true; toUser = user; } }

                                        if (foundToUser)
                                        {
                                            int amountToSend;
                                            try 
                                            {
                                                Console.Write("Amount to send");
                                                amountToSend = int.Parse(Console.ReadLine() ?? "0");
                                                if (Utils.CheckBalance(currUser, amountToSend))
                                                {
                                                    toUser.Card.Balans += amountToSend;
                                                    currUser.Card.Balans -= amountToSend;
                                                    currUser.Operations.Add($"{toUser.Card.PAN} kartina {amountToSend} AZN kocurme");
                                                    toUser.Operations.Add($"{currUser.Card.PAN} kartindan {amountToSend} AZN kocurme");
                                                }
                                            }

                                            catch (Exception ex) { Console.WriteLine(ex); Thread.Sleep(700); continue; }
                                        }
                                        break;
                                }
                                if (optOperations == -1 || optOperations == 3) break;
                            }
                            break;
                        case 2:
                            currUser.ShowOperations();
                            break;
                    }

                    if (optUserPanel == -1 || optUserPanel == 3) break;
                }
            }
        }
    }

    else if (optMainMenu == 1)
    {
        string? name, surname, pin;

        Console.Clear();
        Console.WriteLine("Yeni istifadeci ucun parametrleri teyin edin:");

        Console.Write("\n\nAd: "); name = Console.ReadLine();
        Console.Write("\nSoyad: "); surname = Console.ReadLine();

        while (true)
        {
            Console.Write("\n4 reqemli PIN: ");
            pin = Console.ReadLine();


            foreach (User user in users)
            {
                if (user.PIN == pin)
                {
                    Console.WriteLine("PIN artiq istifade olunur, yenisini daxil edin");
                    Thread.Sleep(500);
                    break;
                }
            }

            if (pin?.Length != 4)
            {
                Console.WriteLine("\n\nPIN 4 reqemli olmalidir");
                Thread.Sleep(500);
                continue;
            }

            else break;
        }

        users.Add(new User(name ?? "NULL", surname ?? "NULL", pin));

        Console.Clear();
        Console.WriteLine("User yaradildi, sign in edin");
    }

    else if (optMainMenu == 2 || optMainMenu == -1) return;
}
