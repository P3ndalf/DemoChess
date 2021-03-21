using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Menu
    {
        static int menuPosition;
        static int menuSize;
        static string[] menuItems;

        public Menu()
        {
            menuPosition = 0;
            menuSize = 3;
            menuItems = new string[menuSize];
            menuItems[0] = "\t\t 1 -  Создать шахматную партию;";
            menuItems[1] = "\t\t 2 -  Справка;";
            menuItems[2] = "\t\t 3 -  Выход;";
        }

        public static void menuPrint()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t BnW ChessGame 2d");
                for (int i = 0; i < menuSize; i++)
                {
                    if (i == menuPosition)
                        Console.WriteLine("=>" + menuItems[i] );
                    else
                        Console.WriteLine(menuItems[i]);
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.S:
                        if (menuPosition < menuSize - 1) menuPosition++;
                        else if (menuPosition == menuSize - 1) menuPosition = 0;
                        break;
                    case ConsoleKey.W:
                        if (menuPosition > 0) menuPosition--;
                        else if (menuPosition == 0)
                            menuPosition = menuSize - 1;
                        break;
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            decision(menuPosition);
                            if (menuPosition == 2) return;
                        }
                        break;
                }
            }
        }
        public static void decision(int menuPosition)
        {
            switch (menuPosition)
            {
                case 0:
                    {
                        Visualize.Creature();
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Типо справка, а так идите нахер я вас не звал");
                        while (true)
                        {
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                                return;
                        }
                    }
                case 2: return;
                default: return;
            }
        }
     
    }
}
