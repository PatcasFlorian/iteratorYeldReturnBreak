using System;
using System.Collections.Generic;
namespace IteratorYeldReturnBreak
{

   
    class Program
    {

        public static IEnumerable<int> GetMyMaxValue()
        {

            int maxValue = Int32.MaxValue;

            for (int items = 0; items <= maxValue; items++)
            {
                if (items == maxValue/50000)
                {
                    yield break;
                }

                yield return items;
            }
        }
        static void Main(string[] args)
        {
           

            // Display the elements return from iteration 
            foreach (var i in GetMyMaxValue())
            {
                Console.WriteLine(i);
            }

        }

       


    }
}
