using System;
using System.Collections.Generic;
using NumberUtility;

namespace NumberCruncher
{
    public static class Program
    {
        public static void Main()
        {
            //Create a list of ints 
            //Call SumOfEvenNumbers in NumberUtility and pass this list in
            //Pring out the result

            List<int> someNumbers = new List<int> { 1, 2, 6, 3, 5, 8, 9, 10, 2, 16 };

            int sum = NumberUtility.NumberUtility.SumOfEvenNumbers(someNumbers);

            Console.WriteLine($"Sum of even integers in the given list is: " + sum);
            Console.ReadLine();
        }
    }
}
