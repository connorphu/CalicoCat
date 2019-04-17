using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    class MyCalculator
    {
        // Declaring a function
        // [scope] [return type] [function name](parameter)
        /* 1. Scope:
         * public - any class in any namespace can use
         * private - only current class can use
         * internal (default) - any class in the same namespace can use
         */
         /* 2. Return Type:
          * any type that the function is expected to 'return'
          * void - if nothing is being return
          */
         /* 3. Functions:
          * parameters - things that the function expects for it to work (ie. 2 integers num1 and num2)
          */
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


    }
}
