using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankk
{
    internal class Menu
    {
        private List<string> _options;
        public List<string> Options { get; set; }

        public Menu(ref List<string> options) => _options = options;
        public Menu(List<string> options) => _options = options;

        public void Print(ref int option)
        {
            Console.Clear();

            if (option >= _options.Count) option = 0;
            else if (option < 0) option = _options.Count - 1;

            for (int i = 0; i < _options.Count; i++)
            {
                if (option == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (_options[i].Length / 2)) + "}", _options[i]));
                    Console.ResetColor();
                }
                else Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (_options[i].Length / 2)) + "}", _options[i]));
            }
        }

        public void Print(ref int option, string optionalMessage)
        {
            Console.Clear();
            Console.WriteLine(optionalMessage);

            if (option >= _options.Count) option = 0;
            else if (option < 0) option = _options.Count - 1;

            for (int i = 0; i < _options.Count; i++)
            {
                if (option == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (_options[i].Length / 2)) + "}", _options[i]));
                    Console.ResetColor();
                }
                else Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (_options[i].Length / 2)) + "}", _options[i]));
            }
        }

        public int Start()
        {
            ConsoleKeyInfo key;
            int option = 0;

            while (true)
            {
                Print(ref option);
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape) return -1; // exit code
                else if (key.Key == ConsoleKey.Enter) return option;
                else if (key.Key == ConsoleKey.DownArrow) option++;
                else if (key.Key == ConsoleKey.UpArrow) option--;
            }
        }

        public int Start(string optionalMessage)
        {
            ConsoleKeyInfo key;
            int option = 0;

            while (true)
            {
                Print(ref option, optionalMessage);
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape) return -1; // exit code
                else if (key.Key == ConsoleKey.Enter) return option;
                else if (key.Key == ConsoleKey.DownArrow) option++;
                else if (key.Key == ConsoleKey.UpArrow) option--;
            }
        }
    }
}
