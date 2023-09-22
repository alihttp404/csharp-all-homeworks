using documenbt;
using EzMenu;

Menu mainMenu = new Menu(new List<string>
{
    "Enter key",
    "Exit"
});

while (true)
{
    int mainMenuOpt = mainMenu.Start();

    switch (mainMenuOpt)
    {
        case 0:
            Console.Clear();
            Console.Write("Enter product key: ");
            string? key = Console.ReadLine();

            switch (key)
            {
                case "basic":
                    DocumentProgram docProgram = new DocumentProgram();
                    docProgram.Run();
                    Thread.Sleep(3000);
                    break;

                case "pro":
                    DocumentProgram proDocumentProgram = new ProDocumentProgram();
                    proDocumentProgram.Run();
                    Thread.Sleep(3000);
                    break;

                case "expert":
                    DocumentProgram expertDocumentProgram = new ExpertDocumentProgram();
                    expertDocumentProgram.Run();
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("Key invalid");
                    Thread.Sleep(3000);
                    break;
            }

            break;

        case 1:
            return;
    }
}