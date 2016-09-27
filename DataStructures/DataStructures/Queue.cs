using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue
    {

        static public void displayMenu()
        {
            Console.WriteLine("\n\n-------QUEUE MENU-------");
            Console.WriteLine("1. Add one time to Queue");
            Console.WriteLine("2. Add Huge List of Items to Queue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Delete from Queue");
            Console.WriteLine("5. Clear Queue");
            Console.WriteLine("6. Search Queue");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Menu Selector: ");
        }
        static public int menu(){

            Queue<string> myQueue = new Queue<string>();
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            

       

            int iSelect = 3; //random number to get in the while loop
            while (iSelect != 7)
            {

                displayMenu();

                ErrorHandling check = new ErrorHandling();

                iSelect = check.Input("Menu Selector: ", 7);

                if (iSelect == 1)
                {
                    Console.WriteLine("Enter a string");
                    String sString = Console.ReadLine();
                    myQueue.Enqueue(sString);


                }
                else if (iSelect == 2)
                {
                    myQueue.Clear();
                    for (int iCount = 1; iCount <= 20; iCount++)
                    {

                        myQueue.Enqueue("New Entry " + iCount);
                    }
                }
                else if (iSelect == 3)
                {
                    foreach (String s in myQueue)
                    {
                        Console.WriteLine(s);
                    }

                }
                else if (iSelect == 4)
                {
                    Console.WriteLine("Which entry do you want to delete?");
                    int iDelete = Convert.ToInt32(Console.ReadLine());
                    int iNum = myQueue.Count;
                    Queue<string> myQueue2 = new Queue<string>();
                    for (int iCount2 = 0; iCount2 < iNum; iCount2++)
                    {
                        if (iCount2 == iDelete - 1)
                        {
                            myQueue.Dequeue();
                        }
                        else
                        {
                            myQueue2.Enqueue(myQueue.Dequeue());
                        }
                    }
                    myQueue = myQueue2;



                }
                else if (iSelect == 5)
                {
                    myQueue.Clear();
                    Console.WriteLine("Queue has been cleared");
                }
                else if (iSelect == 6)
                {
                    Console.WriteLine("What entry do you want to search for?");
                    string sSearch = Console.ReadLine();
                    stopwatch.Start();
                    /*for (int iCount2 = 0; iCount2 < iSearch; iCount2++)
                    {
                        myQueue.Peek();
                        if (iCount2 == iSearch)
                        {
                            Console.WriteLine(myQueue.Peek());
                        }
                    }
                     * */

                    if (myQueue.Contains(sSearch))
                    {
                        Console.WriteLine("Item found!");
                        stopwatch.Stop();
                        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                    }
                    else
                    {
                        Console.WriteLine("Item not found.");
                        stopwatch.Stop();
                        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                    }

                }
                else if (iSelect == 7)
                {
                    
                    
                    return 0;
                    
                    

                }//Return to main Menu
               
               
                
                
            }

            return 0;
            


        }

    }
}