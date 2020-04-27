using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class WhileLoop
    {

        //member variables
        public int whileLoop;
        public int counter = 5;
        public string whileInput;


        //constructor
        public WhileLoop()
        {
        }


        //member methods
        public void While()
        {
            Console.WriteLine("Please enter a numerically typed number");
            whileInput = Console.ReadLine();
            {
                counter = Int32.Parse(whileInput);
            }
            while (counter < 25)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }


    }
}
