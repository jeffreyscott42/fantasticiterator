using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasure.Core;

namespace ClearMeasure
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide the starting value");
            string startStr = Console.ReadLine();

            Console.WriteLine("Please provide the ending value");
            string endStr = Console.ReadLine();

            int startValue = int.Parse(startStr);
            int endValue = int.Parse(endStr);
            string result = "";

            // APPROACH #1 - Internal
            //PerformCalculation(startValue, endValue);

            FantasicIterator myIterator = new FantasicIterator();

            // APPROACH #2 - Class with hardocded selection criteria
            //result = myIterator.IterateRange(startValue, endValue);

//            myIterator.AddRequest(new DivisorRequest(0, "yowsa"));
            myIterator.AddRequest(new DivisorRequest(9, "yowsa"));
            myIterator.AddRequest(new DivisorRequest(5, "redonkulous"));
            myIterator.AddRequest(new DivisorRequest(7, "beautimus"));

            // APPROACH #3 - User-customizable selection criteria and values
            result = myIterator.Iterate(startValue, endValue);
 
            Console.WriteLine(result);
            Console.ReadLine();
            
        }

      
    //    private static void PerformCalculation(int startValue, int endValue)
    //    {

    //        //int start = 1;
    //        //int end = 100;

    //        for (int i = startValue; i <= endValue; i++)
    //        {

    //            StringBuilder sb = new StringBuilder();
                
    //            if (i % 3 == 0)
    //            {
    //                //Console.WriteLine("Fizz");
    //                sb.Append("Fizz");
    //            }

    //            if (i % 5 == 0)
    //            {
    //                //Console.WriteLine("Buzz");
    //                if (sb.Length > 0)
    //                {
    //                    sb.Append(",");
    //                }
    //                sb.Append("Buzz");
    //            }
                
    //            if(sb.Length == 0)
    //            {
    //                sb.Append(i.ToString());

    //            }
    //            Console.WriteLine(sb.ToString());
               

    //        }

    //        Console.ReadLine();

    //    }
    }
}
