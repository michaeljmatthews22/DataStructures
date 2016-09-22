using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Group_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMainMenu;
            int iStackMenu;
            int iQueueMenu;
            int iDictionaryMenu;
            bool bReturnToMain = true;
            bool bMainMenu = true;
            while (bMainMenu)
            {
                bReturnToMain = true;
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1.    Stack");
                Console.WriteLine("2.    Queue");
                Console.WriteLine("3.    Dictionary");
                Console.WriteLine("4.    Exit");
                Console.Write("Menu Selector: ");
                iMainMenu = Convert.ToInt16(Console.ReadLine());
                while (bReturnToMain)
                {
                    if (iMainMenu == 1)
                    {
                        /////////ENTER CODE FOR MENU OF A STACK
                        Console.WriteLine("\n\n-------STACK MENU-------");
                        Console.WriteLine("1. Add one time to Stack");
                        Console.WriteLine("2. Add Huge List of Items to Stack");
                        Console.WriteLine("3. Display Stack");
                        Console.WriteLine("4. Delete from Stack");
                        Console.WriteLine("5. Clear Stack");
                        Console.WriteLine("6. Search Stack");
                        Console.WriteLine("7. Return to Main Menu");
                        Console.Write("Menu Selector: ");
                        iStackMenu = Convert.ToInt16(Console.ReadLine());
                        if (iStackMenu == 1)
                        {
                        }
                        else if (iStackMenu == 2)
                        {
                        }
                        else if (iStackMenu == 3)
                        {
                        }
                        else if (iStackMenu == 4)
                        {
                        }
                        else if (iStackMenu == 5)
                        {
                        }
                        else if (iStackMenu == 6)
                        {
                        }
                        else if (iStackMenu == 7)
                        {
                            bReturnToMain = false;
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid menu option");
                        }
                    }
                    else if (iMainMenu == 2)
                    {
                        /////////ENTER CODE FOR MENU OF A QUEUE
                        Console.WriteLine("\n\n-------QUEUE MENU-------");
                        Console.WriteLine("1. Add one time to Queue");
                        Console.WriteLine("2. Add Huge List of Items to Queue");
                        Console.WriteLine("3. Display Queue");
                        Console.WriteLine("4. Delete from Queue");
                        Console.WriteLine("5. Clear Queue");
                        Console.WriteLine("6. Search Queue");
                        Console.WriteLine("7. Return to Main Menu");
                        Console.Write("Menu Selector: ");
                        iQueueMenu = Convert.ToInt16(Console.ReadLine());
                        if (iQueueMenu == 1)
                        {
                        }
                        else if (iQueueMenu == 2)
                        {
                        }
                        else if (iQueueMenu == 3)
                        {
                        }
                        else if (iQueueMenu == 4)
                        {
                        }
                        else if (iQueueMenu == 5)
                        {
                        }
                        else if (iQueueMenu == 6)
                        {
                        }
                        else if (iQueueMenu == 7)
                        {
                            bReturnToMain = false;
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid menu option");
                        }
                    }
                    else if (iMainMenu == 3)
                    {
                        //////////ENTER CODE FOR A MENU OF A DICTIONARY
                        Console.WriteLine("\n\n-------DICTIONARY MENU-------");
                        Console.WriteLine("1. Add one time to Dictionary");
                        Console.WriteLine("2. Add Huge List of Items to Dictionary");
                        Console.WriteLine("3. Display Dictionary");
                        Console.WriteLine("4. Delete from Dictionary");
                        Console.WriteLine("5. Clear Dictionary");
                        Console.WriteLine("6. Search Dictionary");
                        Console.WriteLine("7. Return to Main Menu");
                        Console.Write("Menu Selector: ");
                        iDictionaryMenu = Convert.ToInt16(Console.ReadLine());
                        if (iDictionaryMenu == 1)
                        {
                        }
                        else if (iDictionaryMenu == 2)
                        {
                        }
                        else if (iDictionaryMenu == 3)
                        {
                        }
                        else if (iDictionaryMenu == 4)
                        {
                        }
                        else if (iDictionaryMenu == 5)
                        {
                        }
                        else if (iDictionaryMenu == 6)
                        {
                        }
                        else if (iDictionaryMenu == 7)
                        {
                            bReturnToMain = false;
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid menu option");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid menu option");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}