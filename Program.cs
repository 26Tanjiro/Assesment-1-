using System;
using System.Linq;

namespace Asses;

internal static class Program
{
	 static void Main()
	{
      
        
  Console.WriteLine("Jake Joshua B. Peñalosa");
	Console.Write("BSCpE 1-1");
	Console.Write("\n");
	Console.Write("------------------------------------------------");
    Console.Write("\n");  
    Console.WriteLine("\n              **Create Account**");   
    Console.Write("------------------------------------------------");
	Console.Write("\n Enter your Username:");
        string username = Console.ReadLine();
        
	Console.Write("\n Enter your Password:");	
	  string pass= Console.ReadLine();
	 
	 
	  Console.WriteLine("\n         **Login**");
	  Console.Write("\n   !!Please enter to proceed!!");
	  string login=Console.ReadLine();
	  
	  Console.Write("------------------------------------------------");
	  Console.WriteLine("**Welcome,please enter your account**");
	  
	  
	  
	  int attempts= 4;

		
        while (attempts>0)
        {
        Console.Write("\n");
        Console.WriteLine("Username:");
		string usern= Console.ReadLine();
        Console.WriteLine("Password:");
            string password = Console.ReadLine();
       
            if (password.EndsWith(pass) && username.EndsWith(usern))
            {
                Console.WriteLine("**Login successful! Welcome, " + username +"!**");
                return;   
            }
            else
            {
                attempts--;
Console.WriteLine("Invalid username or password. You have ("+ attempts +") attempts remaining.");
            }
        }

 Console.WriteLine("You have run out of attempts. Access denied.");
    }  
}

	

