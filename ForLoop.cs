using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CriticalThinkingWorksheet
{
    class ForLoop
    {
    //Write a loop that will run as many times as a user wants.  
	//Change the loop to run “Forward” again.
	//Take in user input and use the value to run the for loop.
	//Valuable research terms:
	//“How do I capture user input in C#”
	//“How do I convert a string into an int in C#”



        //variables
        public int forLoop;
        public string userInput;
        //constructors
        public ForLoop()
        {
        }
        //methods
        //for loop
        public string CaptureInputForLoop()
        {
            Console.WriteLine("Enter a numerically typed number for how many times the loop should run.");
            userInput = Console.ReadLine();
            return userInput;
        }

        public void ConvertUserInput()
        {
            forLoop = Int32.Parse(userInput);
            
        }
        public void DoForLoop()
        {
            ConvertUserInput();
            for ( int i = 0; i < forLoop ; i++)
            {
                Console.Write(i);
            }
        }

    }
}
