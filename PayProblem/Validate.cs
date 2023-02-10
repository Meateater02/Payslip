using System;

namespace PayProblem;

public class Validate
{
    //check for input
    public string CheckUserInput()
    {
        string userInput = null;
        while ( userInput == null)
        {
            try
            {
                userInput = Console.ReadLine();
            }
            catch (NullReferenceException e)
            {
                Console.Write("Your name cannot be blank. \nPlease try again: ");
                throw;
            }
        }

        return userInput;
    }
    
    //validate for date
    
    //validate for integers
    public int Int(int number)
    {
        try
        {
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        //check for positive number
        if (number < 0)
        {
            Console.WriteLine("Must be a positive number!");
            Console.WriteLine("Please try again: ");
            
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public int Rate(int number)
    {
        if (number < 0 || number > 50)
        {
            Console.WriteLine("Super rate must be in the range of 0 - 50!");
            Console.WriteLine("Please try again: ");

            return 0;
        }
        else
        {
            return 1;
        }
    }
}