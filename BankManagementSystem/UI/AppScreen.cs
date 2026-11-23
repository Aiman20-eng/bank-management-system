using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class AppScreen
{
	public AppScreen()
	{
		internal static void welcome()
	{

        // clears the console screan 
        Console.Clear();
        // sets this title of the console app 
        Console.Title = "Atm app ";
        //sets the text color or foreground color 
        Console.ForegroundColor = ConsoleColor.White;
        //set the welcome massage 
        Console.WriteLine("\n\n ----------------- welcome to my ATM app -----------------\n\n");
        Console.WriteLine("please insert your ATM card ");

        Utilty.pressEnterToCont

    }
   
}
}
