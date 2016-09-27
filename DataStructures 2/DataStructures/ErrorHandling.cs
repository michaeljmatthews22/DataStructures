using System;

/// <summary>
/// This class is meant to handle all erros. This is what we need when we are taking input from 
/// a string, especially if it is an int. 
/// 
/// you can call this class from anywhere in the program
/// </summary>
namespace DataStructures
{
    class ErrorHandling
 
    {
        public int Input(string prompt, int max)
        {
            do //DO UNTIL LOOP RETURNS A DESIRED VALUE
            {
                int min = 0; //YOU HAVE TO have at least one
                
                string input = Console.ReadLine(); //GET INPUT
                try //HANDLE INVALID INPUTS
                {
                    if (Convert.ToInt16(input) < min) //IS INPUT UNWANTED?
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Minimum number of team not met. \rPlease input " + min + " to " + max + " teams.");
                    }
                    else if (Convert.ToInt16(input) > max)
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Maximum number of teams exceeded. \rPlease input " + min + " to " + max + " teams.");
                    }
                    else
                    {
                        return Convert.ToInt16(input); //RETURNS INT
                    }
                }
                catch (FormatException) //EXCECUTE IF USER DOES NOT INPUT INT
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Invalid input type. \rPlease enter an integer between " + min + " and " + max + ".");
                    
                }
                catch (OverflowException)
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Maximum number of teams exceeded. \rPlease input " + min + " to " + max + " teams.");
                }
            } while (true);
        }
       
        //this is the main part of the clearing the input so that the user doesn't have to reenter bad data
        public void clearInput(string input, string prompt)
        {
            Console.CursorTop--; //MOVE CURSOR UP ONE
            for (int i = 0; i < prompt.Length; i++) //MOVE CURSOR TO END OF PROMPT
            {
                Console.CursorLeft++;
            }
            for (int i = 0; i < input.Length; i++) //CLEAR PREVIOUS INPUT
            {
                Console.Write(" ");
            }
            for (int i = 0; i < input.Length; i++) //RETURN CURSOR TO INPUT START
            {
                Console.CursorLeft--;
            }
        }
    }
}


