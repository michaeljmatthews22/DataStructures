using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ProtectedMenu
    {
        public static bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(_FileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}",
                                  _Exception.ToString());
            }

            // error occured, return false
            return false;
        }
        
        //source for above http://stackoverflow.com/questions/6397235/write-bytes-to-file
        
        public static void menu()
        {
                
            Console.WriteLine("\n\n-------DICTIONARY MENU-------");
            Console.WriteLine("1. Encrypt");
            
            Console.WriteLine("2. Return to Bonus Feature menu");
            Console.Write("Menu Selector: ");

            ErrorHandling check = new ErrorHandling();

            int iProtectedMenu = check.Input("Menu Selector: ", 2);

            switch(iProtectedMenu){
                case 1:


                    Console.WriteLine("Enter in the data that you want to save from this program...");
                    //Encrypt the data.
                    byte[] secret = Encoding.UTF8.GetBytes(Console.ReadLine());

                    //Encrypt the data.
                    byte[] encryptedSecret = Encrypt.Protect(secret);

                    Console.WriteLine("The encrypted byte array is:");
                    Encrypt.PrintValues(encryptedSecret);

                    ByteArrayToFile("C:\\Users\\Public\\Encryption\\encryption.txt", encryptedSecret);

                    Console.Write("\nData is now encrypted\n\n");
                    
                break;
                
                default:
                Console.Write("\nGoodbye!");
                break;
            }

            

            

            

            }
    }
}
