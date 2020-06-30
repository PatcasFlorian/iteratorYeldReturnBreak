using System;
using System.Collections.Generic;
namespace IteratorYeldReturnBreak
{

    class Iterator
    {

        public static IEnumerable<int> GetMyMaxValue()
        {
           
            int maxValue= Int32.MaxValue;
            
            for (int items = 0;items <= maxValue;items++)
            {
                if (items > maxValue - 3)
                {
                 yield break;
                }

                yield return items;
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> myitems = GetMyMaxValue();
            // Display the elements return from iteration 
            foreach (var i in GetMyMaxValue())
            {
                Console.WriteLine(i);
            }
            
        }

        private static IEnumerable<string> GetMyMaxValue()
        {
            throw new NotImplementedException();
        }
    }
}
