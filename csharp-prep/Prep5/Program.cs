using System;

class Program
{
    static void Main(string[] args)
    {
        //DisplayWelcomeMessage

        //store user name
        string userName = AskUserName();
        //store user number
        int userNumber = AskUserNumber();


        int squredNumber = squreNumber(userNumber);

        DisplayResults(userName, squredNumber);
    {
    //static void DisplayWelcomeMessage()
    }
        // write to the terminal
        Console.WriteLine("Wecome to the Program");
    }

    //ask user name function
    static string AskUserName()
    { 
        //display to the window
        Console.Write("What is your name:");
        //get the respond from the user
        string name = Console.ReadLine();

        //keeps the user input
        return name;
    }
    //ask user number function
    static int AskUserNumber()

    {
        //write to the window
        Console.Write("Please enter your magic number:");
        // read from the window
        int number = int.Parse(Console.ReadLine());


        //keep the answer from the user
        return number;
    }

    // get squre function with int number as a parameter.
     static int squreNumber(int number)
     {
        //compute the squre
        int squre = number * number;
        // keep the number
        return squre;
     }

     // Shows name and number to the user.
    static void DisplayResults(string name, int squre)
    {
        Console.WriteLine($"{name}, the power of your number is {squre}");
    }













} 