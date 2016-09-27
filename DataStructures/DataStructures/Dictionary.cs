using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Dictionary
    {
        static public int menu()
        {

            int iDictionaryMenu = 0;

            while (iDictionaryMenu != 7)
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
                ErrorHandling check = new ErrorHandling();

                iDictionaryMenu = check.Input("Menu Selector: ", 7);


                Dictionary<string, int> myDictionary = new Dictionary<string, int>();
                string sDictionaryString;
                int iDictionaryCount;




                    if (iDictionaryMenu == 1)
                    {
                        //ManageDictionary.addOne
                        //Add one string to the dicitonary
                        Console.WriteLine("Enter a string into the data structure: ");
                        sDictionaryString = Console.ReadLine();
                        myDictionary.Add(sDictionaryString, myDictionary.Count);



                    }//Dictionary Menu 1 One
                    else if (iDictionaryMenu == 2)
                    {
                        //ManageDictionary.AddList
                        myDictionary.Clear();
                        for (iDictionaryCount = 0; iDictionaryCount < 2000; iDictionaryCount++)
                        {
                            myDictionary.Add("New entry # " + (iDictionaryCount), iDictionaryCount);
                        }
                    }//DictionaryMenu 2 list
                    else if (iDictionaryMenu == 3)
                    {
                        //ManageDictionary.Display
                        foreach (KeyValuePair<string, int> s in myDictionary)
                        {
                            Console.Write(s.Key + " ");
                            Console.WriteLine(s.Value);
                        }
                    }//Dictionary Menu 3 Display
                    else if (iDictionaryMenu == 4)
                    {
                        //ManageDictionary.Delete
                        Console.WriteLine("What entry would you like to delete? ");
                        string sInput = Console.ReadLine();
                        //while loop. 
                        if (myDictionary.ContainsKey(sInput))
                        {
                            myDictionary.Remove(sInput);
                        }//Delete Dictionary 
                        else
                        {
                            Console.WriteLine("The entry you would like to remove was not found. Please enter a valid entry.");
                        }
                    }//Dictionary menu 4
                    else if (iDictionaryMenu == 5)
                    {
                        //ManageDictionary.Clear
                        myDictionary.Clear();
                    }//Clear Dictionary Menu 5
                    else if (iDictionaryMenu == 6)
                    {
                        //ManageDictionary.Search

                        Console.WriteLine("\nEnter an item you would like to search for:\n");
                        string sSearchEntry = Console.ReadLine();
                        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                        sw.Start();
                        if (myDictionary.ContainsKey(sSearchEntry))
                        {
                            Console.WriteLine("\nValue for " + sSearchEntry + " is " + myDictionary[sSearchEntry]);
                            sw.Stop();
                            // Get the elapsed time as a TimeSpan value.
                            TimeSpan ts = sw.Elapsed;
                            Console.WriteLine("Time Elapsed: " + ts);
                        }
                        else
                        {
                            Console.WriteLine("\nItem not found.");
                        }
                    }//Search Dictionary Menu 6
                    else if (iDictionaryMenu == 7)
                    {
                        //ManageDictionary.Return
                        Console.WriteLine("\n");
                        return 0;

                    }//Return to main Menu


                }//end of while loop

                return 0;
            }//end of menu
        }
    
}


