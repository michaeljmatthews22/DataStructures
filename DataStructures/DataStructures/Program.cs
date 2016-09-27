using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                {
                    case 1:
                        manageStack.menuDisplay();

                        ErrorHandling checking = new ErrorHandling();

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


/*
 * // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
byte[] plaintext;
plaintext = Encoding.UTF8.GetBytes("this");

// Generate additional entropy (will be used as the Initialization vector)
byte[] entropy = new byte[20];
using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
{
    rng.GetBytes(entropy);
}

            

byte[] ciphertext = ProtectedData.Protect(plaintext, entropy,
    DataProtectionScope.CurrentUser);

Console.Write(ciphertext);*/