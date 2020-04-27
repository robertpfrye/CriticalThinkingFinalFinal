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



        //constructor
        public WhileLoop()
        {
        }


        //member methods
        public void While()
        {
            while(counter < 25)
            {
                counter++;
                Console.WriteLine(counter);
            }

        }


    }
}
