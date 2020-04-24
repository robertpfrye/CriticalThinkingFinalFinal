using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class ForLoop
    {
        //variables
        public int forLoop;
        //constructors
        public ForLoop()
        {
            forLoop = 0;
        }
        //methods
        //for loop
        public void DoForLoop()
        {
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}
