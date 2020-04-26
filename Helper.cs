using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingWorksheet
{
    public static class Helper
    {
        //wrapper method
        public static string GetUserInput(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
        //wrapper method
        public static int GetRandomNumber(int min, int max, Random random)
        {
            return random.Next(min, max);
        }
    }
}
