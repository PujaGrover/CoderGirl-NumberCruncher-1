using System;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    public static class NumberUtility
    {
        //create a static method SumOfEvenNumbers 
        //it should take a list of ints and returns the sum of all even number in that list

        public static int SumOfEvenNumbers(List<int> anyNumbers)
        {
            int result = 0;
            foreach (int i in anyNumbers)
            {
                if (i % 2 == 0)
                    result += i;
            }
            return result;
        }
        
    }
}
