using System;
using System.Security.Cryptography;
  
public static class Encrypt
{

    

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

	public static void PrintValues( Byte[] myArr )  
	{
	      foreach ( Byte i in myArr )  
		  	{
		         Console.Write( "\t{0}", i );
			 }
      Console.WriteLine();
	 }

}