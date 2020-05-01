using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class CalculatorMadness
    {
        //member variables

        //constructor

        //member methods
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }

        public int SubtractTwoNumber(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }

        public void RunCalculations()
        {
            Console.WriteLine("6+5-(40*35/4)+(2*2) is:");
            int value1 = 6;
            int value2 = 5;
            int value3 = 40;
            int value4 = 35;
            int value5 = 4;
            int value6 = 2;

            //parentheses
            int output1 = MultiplyTwoNumbers(value3, value4);
            int output2 = DivideTwoNumbers(output1, value5);
            //exponents
            int output3 = MultiplyTwoNumbers(value6, value6);
            //multiplication
            //division
            //addition
            int output4 = AddTwoNumbers(value1, value2);
            int output5 = AddTwoNumbers(output2, output3);
            //subtractions
            int output6 = SubtractTwoNumber(output4, output5);
            Console.WriteLine("The result of the above calculation is: " +output6);

        }

    }
}
