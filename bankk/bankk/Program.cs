using bankk;

void Main(string[] args)
{
    List<User> users = new List<User>();
    Menu menu = new Menu(new List<string> { "Sign in", "Sign up", "Exit"});

    while (true)
    {
        int opt = menu.Start();

        if (opt == 0)
        {
            if (users.Count == 0) { Console.WriteLine("bosdu"); }
            else
            {
                Console.WriteLine("Enter Pin");
                string pin = Console.ReadLine();
                bool found = false;
                foreach (User user in users)
                {
                    if (user.Card.PIN == pin)
                    {
                        found = true;
                    }
                }
                if (!found) { Console.WriteLine("bele account yyoxdu"); continue; }

                else
                {
                    Menu menu_signin = new Menu(new List<string> { "Balans", "Nagd pul", "Emeliyyatlar", "card to card" });
                    Menu emeliyyatlar = new Menu(new List<string> { "Emeliyyatlar siyahisi" });

                    while (true)
                    {
                        int opt_signin = menu_signin.Start();

                        if (opt == 0)
                        {

                        }
                    }
                }
            }
        }

        else if (opt == 2) return;
    }
}