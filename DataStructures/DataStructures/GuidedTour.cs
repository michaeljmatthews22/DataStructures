using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

  
    class GuidedTour
    {

        public static void typeWriter(string toWrite)
        {
            foreach (var letter in toWrite)
            {

                Console.Write(letter);
                System.Threading.
                Thread.Sleep(50);

            }
            Console.Write("\n");

        }

        public static void guide()
        {
            
            typeWriter("Welcome to the guided tour. You may not be familiar with Data Structures, and that's okay");
            typeWriter("If you want more information, you can use the 'man' pages to find out more. \nFor now, we'll show you how to use this program\n");
            System.Threading.
            Thread.Sleep(1500);
            typeWriter("In this example, we'll walk you through a 'Stack' DataType");
            
            typeWriter("Lets look at our options");
            System.Threading.
            Thread.Sleep(1500);
            
            manageStack.menuDisplay();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("You'll notice that you can add, remove, search and do many more things with a stack. Lets get started");
            
            typeWriter("Let enter in option 1 and it'll prompt us for a string");
            
            typeWriter("1");

            manageStack.addOne();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);

            typeWriter("You added an item! Congrats! Let's make sure it is there. The menu will come up again...");

            manageStack.menuDisplay();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("Lets look and see if there is anything in the Stack...");

            typeWriter("Lets choose option 3 to see what we have in the Stack");
           
            typeWriter("3");

            manageStack.display();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("See! Its there! Now lets search for it");

            manageStack.menuDisplay();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("Lets hit 6 to search. Make sure to type in the same element you orginally put in. \n 6");

            manageStack.search();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
           
            typeWriter("Hopefully that worked. Now lets delete that item and then search again to make sure it was removed");

            manageStack.menuDisplay();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("Make sure to type in the element for me.  Lets hit four now \n 4");

            manageStack.delete();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("Lets see if that worked...");
            manageStack.menuDisplay();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            
            typeWriter("3");
            manageStack.display();
            Console.WriteLine("\n");
            System.Threading.
            Thread.Sleep(2000);
            

            Console.Write("\n\n ");

           typeWriter("Congrats. Hopefully you now understand more about DataStructures!\n\n Have a good one \n \n");


        }
    }
}
