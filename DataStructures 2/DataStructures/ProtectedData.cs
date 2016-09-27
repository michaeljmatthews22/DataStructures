using System;
using System.Security.Cryptography;
 /*
  * 
  * This code is meant to encrypt all of the data. This is public code.
  * 
  * This will take ht eoptions that the user is trying to bass and write it to a file
  * 
  * */
public static class Encrypt
{

    
    //Converitng something into a byte
	public static byte [] Protect( byte [] data )
	{
		try
		{
            byte[] s_aditionalEntropy = { 9, 8, 7, 6, 5 };
			// Encrypt the data using DataProtectionScope.CurrentUser. The result can be decrypted
			//  only by the same current user.
			return ProtectedData.Protect( data, s_aditionalEntropy, DataProtectionScope.CurrentUser );
           
		} 
		catch (CryptographicException e)
		{
			Console.WriteLine("Data was not encrypted. An error occurred.");
			Console.WriteLine(e.ToString());
			return null;
		}
	}

    //Unprotecting the code
	public static byte [] Unprotect( byte [] data )
	{
		try
		{
            byte[] s_aditionalEntropy = { 9, 8, 7, 6, 5 };
			//Decrypt the data using DataProtectionScope.CurrentUser.
			return ProtectedData.Unprotect( data, s_aditionalEntropy, DataProtectionScope.CurrentUser );
		} 
		catch (CryptographicException e)
		{
			Console.WriteLine("Data was not decrypted. An error occurred.");
			Console.WriteLine(e.ToString());
			return null;
		}
	}

    //printing the values so that the user can see
	public static void PrintValues( Byte[] myArr )  
	{
	      foreach ( Byte i in myArr )  
		  	{
		         Console.Write( "\t{0}", i );
			 }
      Console.WriteLine();
	 }

}