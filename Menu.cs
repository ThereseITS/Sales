using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace Sales
{
    class Menu
    {
        string[] _menuOptions;

        public Menu(string[] menuOptions)
        {
            _menuOptions = menuOptions;
        }
      public int GetMenuChoice()
        {
            int menuChoice = 0;
            do
            {
                for (int i = 0; i < _menuOptions.Length; i++)
                    WriteLine($"{i + 1} . {_menuOptions[i]}");

                WriteLine("Enter Choice:");
                while (!int.TryParse(ReadLine(), out menuChoice))
                {
                    WriteLine($"Please enter a number between 1 and {_menuOptions.Length}:");
                }

                if ((menuChoice > _menuOptions.Length) || (menuChoice < 1))
                {
                    WriteLine($"Please enter a number between 1 and {_menuOptions.Length}:");
                }

            }
            while ((menuChoice > _menuOptions.Length) || (menuChoice < 1));
            return menuChoice;
        }
    }
}
