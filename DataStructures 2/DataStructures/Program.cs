using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Authors: Ben N, Alex Z, Michael M, Jeremy C


Description: Write a program in C# using a console application that demonstrates the use of a Stack, Queue, and Dictionary (Map). I want you to start trying to use GitHub for this assignment.

Make sure you document your code. This might seem like a big program but it really isn't since a lot of the code is copied and reused. In fact, it might be a good idea as a group to divide up the work and then try to bring it all together into one project.

When completed, everyone needs to zip the project and upload to Learning Suite and make sure code is committed to GitHub.

As a group, schedule a time with the TAs for grading


add one item to ... - prompts the user to enter a string and then inserts the input into the data structure.

Add Huge List of Items to ... – first clears the data structure and then generate 2,000 items in the data structure with the value of “New Entry” concatenated with the number. For example, New Entry 1, New Entry 2, New Entry 3. For the dictionary, the key will be the generated string ("New Entry 2") and the value will be the current number (2).

Display ... - display the contents of the data structure. You must use the foreach loop when displaying the data. Handle any errors and inform the user.

Delete from ... - prompt for which item to delete from the structure. Handle any errors and inform the user.

Clear ... - wipe out the contents of the data structure

Search ... - Search for an item in the data structure and return if it was found or not found and how long it took to search. You can create a StopWatch object using code like so:

*/
namespace DataStructures
{
    class Program
    {
        
        static public int dataMenu(string choice)
        {
            int iMainMenu;
            
            
            bool bMainMenu = true;
            while (bMainMenu)
            {
                

                //Test change
                Console.Write("\n");
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1.    Stack");
                Console.WriteLine("2.    Queue");
                Console.WriteLine("3.    Dictionary");
                Console.WriteLine("4.    Return to Bonus Features");
                Console.Write("Menu Selector: ");

                ErrorHandling check = new ErrorHandling();

                iMainMenu = check.Input("Menu Selector: ", 4);

                switch (iMainMenu)
                    //goign through eachd of the case scenarios that we need to check
                {
                    case 1:
                        manageStack.menuDisplay();

                        ErrorHandling checking = new ErrorHandling();

                        //checcking the information

                        int iStackMenu = checking.Input("Menu Selector: ", 7);

                        switch (iStackMenu)
                        {
                            case 1:
                                manageStack.addOne();
                                break;

                            case 2:
                                manageStack.addList();
                                break;

                            case 3:
                                manageStack.display();
                                break;



                            case 4:
                                manageStack.delete();
                                break;

                            case 5:
                                manageStack.clear();
                                break;

                            case 6:
                                manageStack.search();
                                break;

                            case 7:
                                
                                Console.WriteLine("\n");
                                break;

                            default:
                                Console.WriteLine("Please enter a valid menu option");
                                break;
                        }
                        break;
                    case 2:
                        Queue.menu();
                        
                        break;
                    case 3:
                        Dictionary.menu();
                        break;
                    case 4:
                        return 0;
                        break;
                    default:
                        Console.Write("Please enter a valid menu option");
                        break;
                }

            

                //end of second while 
            } // end of while
            Console.ReadLine();
            return 0;
        } // end of dataStrucures
        
        static void typerWriter(string toWrite)
        {
            foreach (var letter in toWrite)
            {

                Console.Write(letter);
                System.Threading.
                Thread.Sleep(40);

            }
            Console.Write("\n");

        }

        public static void Main(string[] args)
        {

            /*typerWriter("Welcome to this program. We are excited to have you join us today!");
            typerWriter("We like to get to know our customers. What is your perferred name?");
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            typerWriter("\nGlad to have you join us " + name + ". We have a couple of options for you today.\n");*/

           //random number to enter loop
            while (true)
            {
                Console.WriteLine("-------ABOVE AND BEYOND-------");
                Console.WriteLine("1.    Get Guided Tour");
                Console.WriteLine("2.    View Man Pages");
                Console.WriteLine("3.    Save Data");
                Console.WriteLine("4.    Data Structures");
                Console.WriteLine("5.    Exit");

                Console.Write("Menu Selector: ");

                ErrorHandling check = new ErrorHandling();

                int orginalInput = check.Input("Menu Selector: ", 5);


                switch (orginalInput)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        GuidedTour.guide();
                        break;
                    case 2:
                        ManPages.accessPages();
                        break;
                    case 3:

                        ProtectedMenu.menu();

                        break;
                    case 4:
                        dataMenu("normal");
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                    default:
                        
                        break;
                }

            }
            
    


           
           // var goOnce = dataMenu("watch");
            Console.ReadKey();
        } //end of main
    } //end of Class Program
} //end of the namespace

//Encrypt.PrintValues(originalData);


