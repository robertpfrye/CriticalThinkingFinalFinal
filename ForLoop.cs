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
        public string helloWorld = "Hello World";
        
        //constructors
        public ForLoop()
        {
        }
        
        
        //methods

        //for loop
        //public string CaptureInputForLoop()
        //{
        //    Console.WriteLine("Enter a numerically typed number for how many times the loop should run.");
        //    userInput = Console.ReadLine();
        //    return userInput;
        //}

        
        //public void ConvertUserInput()
        //{
        //    forLoop = Int32.Parse(userInput);
        //}

        
        
        
        public void DoForLoop()
        {








            //two ways to have a loop read and then write a string ⦁	I.e “H,e,l,l,o, ,W,o,r,l,d”
            foreach (char c in helloWorld)
            {
                Console.Write(c);
            }

            Console.Write("\n");

            for ( int i = 0; i < helloWorld.Length ; i++)
            {
                Console.Write(helloWorld[i]);
            }
        }

    }
}
