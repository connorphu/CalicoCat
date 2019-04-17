using System;


namespace OOPConcepts
{
    class Program
    {
        static void Main()
        {
            
            /* Types:
             * int - integer numbers
             * double - decimal numbers
             * string - text (array of char)
             * bool - true/false
             * char - character (one letter)
             * array [] - collection of objects
             */

            // Declaring variable
            // [type] [name of variable]
            int num;
            num = 4;
            int num3 = 27;
            double num2 = 2.2;
            Console.WriteLine(num2);
            char char1 = 'c';
            string word = "this is a string";

            //Creating a MyCalculator object
            MyCalculator myCalc = new MyCalculator();
            Console.WriteLine(myCalc.Add(3, 5));
        }
    }
}
