using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructures
{
    class manageStack
    {
        public static Stack<string> myStack { get; set; }
        public static bool tutAdd = false;
        public static void menuDisplay()
        {
            Console.WriteLine("\n\n-------STACK MENU-------");
            Console.WriteLine("1. Add one time to Stack");
            Console.WriteLine("2. Add Huge List of Items to Stack");
            Console.WriteLine("3. Display Stack");
            Console.WriteLine("4. Delete from Stack");
            Console.WriteLine("5. Clear Stack");
            Console.WriteLine("6. Search Stack");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Menu Selector: ");
        }
        public static void create()
        {
            if (!tutAdd) //Display brief description of data structure if this is the first creation
            {
                addTutorial();
            }
            myStack = new Stack<string>();
        }
        public static void addOne()
        {
            //Create stack if needed
            if (myStack == null)
            {
                create();
            }
            //Prompt user 
            Console.Write("\nEnter string to be added to stack: ");
            //Process request
            string sEntry;
            try
            {
                sEntry = Console.ReadLine();
                if (sEntry != "")
                {
                    myStack.Push(sEntry);
                    //Display status
                    Console.WriteLine("\n\"" + myStack.Peek() + "\" has been added to stack.");
                }
                else
                {
                    throw new InvalidOperationException("No input detected");
                }
            }
            catch
            {
                Console.WriteLine("\nERROR: No input or invalid input detected. Please enter valid input.");
            }
        }
        public static void addList()
        {
            //Create stack if it does not already exist and clear it if it does
            if (myStack == null)
            {
                create();
            }
            else
            {
                myStack.Clear();
            }
            //Push 2000 new entries onto stack
            for (int i = 1; i <= 2000; i++)
            {
                myStack.Push("New Entry " + (i));
            }
            Console.WriteLine("\n2000 new entries have been successfully added to stack.");
        }
        private static void addTutorial()
        {
            //make this text type out slowly
            Console.WriteLine("\nA stack of type string has been created");
            Console.WriteLine("Elements are available on a Last In First Out (LIFO) basis.");
            tutAdd = true;
        }
        public static void display()
        {
            Console.WriteLine("\nStack contents:"); //put a slight delay right here before the loop
            try
            {
                if (myStack.Count == 0)
                {
                    throw new NullReferenceException("Stack has been cleared");
                }
                foreach (string item in myStack)
                {
                    Console.WriteLine(item);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nERROR: Stack is empty. Add entry (1) or list of entries (2) to display stack.");
            }
        }
        public static void delete()
        {
            Stack<string> unloadedStack = new Stack<string>();
            int iRemovePosition;
            bool found = false;
            try
            {
                Console.Write("\nWhich entry would you like to delete? (i.e. '2' - Deletes second available entry): ");
                iRemovePosition = Convert.ToInt32(Console.ReadLine());
                //unload stack into temporary stack; skip item to be deleted
                for (int i = 1; myStack.Count > 0; i++)
                {
                    if (i == iRemovePosition)
                    {
                        Console.WriteLine("Removed: " + myStack.Pop());
                        found = true;
                    }
                    else
                    {
                        unloadedStack.Push(myStack.Pop());
                    }
                }
                //Display error message if target object does not exist
                if (!found)
                {
                    throw new IndexOutOfRangeException("Selected entry does not exist");
                }
            }
            catch
            {
                Console.WriteLine("\nERROR: Selected entry invalid or does not exist.");
            }
            finally
            {
                //reload stack into original stack without deleted item
                for (int i = 0; unloadedStack.Count > 0; i++)
                {
                    myStack.Push(unloadedStack.Pop());
                }
            }
        }
        public static void clear()
        {
            try
            {
                myStack.Clear();
                Console.WriteLine("\nThe stack has been successfully cleared.");
            }
            catch
            {
                Console.WriteLine("\nERROR: Stack has not been created. Create stack through adding entries (1, 2) before proceeding.");
            }
        }
        public static void search()
        {
            //create objects & declare variables
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Stack<string> unloadedStack = new Stack<string>();
            string sSearch;
            bool found = false;
            Console.Write("\nEnter string to be searched for inside stack: ");
            sSearch = Console.ReadLine();
            //unload stack into temporary stack except for condemed entry
            sw.Start(); //start stopwatch
            for (int i = 0; !found && myStack.Count > 0; i++)
            {
                if (myStack.Peek() == sSearch)
                {
                    sw.Stop(); //stop stopwatch
                    Console.WriteLine("Found: " + myStack.Peek());
                    found = true;
                }
                else
                {
                    unloadedStack.Push(myStack.Pop());
                }
            }
            //stop stopwatch if search ended unsuccessfully 
            if (!found)
            {
                sw.Stop();
                Console.WriteLine("Did not find \"" + sSearch + "\" in stack.");
            }
            //Reload stack
            for (int i = 0; unloadedStack.Count > 0; i++)
            {
                myStack.Push(unloadedStack.Pop());
            }
            //Display time result
            Console.WriteLine("Elapsed time: " + sw.Elapsed);
        }
    }
}