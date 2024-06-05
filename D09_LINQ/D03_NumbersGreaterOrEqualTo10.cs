using System;
using System.Collections.Generic;
using System.Linq;
using D00_Utility;

namespace D09_LINQ
{
    internal class D03_NumbersGreaterOrEqualTo10
    {
        static List<int> listNumbers = new List<int>();

        internal static void CreateListNumbers()
        {
            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++) 
            {
                listNumbers.Add(randomNumber.Next(0, 50)); 
            }

        }

        internal static void NumbersGreaterOrEqualTo10MethodsSyntax()
        {

            var numbers = listNumbers.Where(number => number >= 10).OrderBy(n => n);

            Utility.WriteTitle("Numbers Greater or Equal to 10 - Method Syntax");

            foreach (var n in numbers)
            {
                Utility.WriteMessage(n.ToString(), "", "\n");
            }
        }

        internal static void NumbersGreaterOrEqualTo10QuerySyntax()
        {
            var numbersGreaterOrEqualTo10 =
                from n in listNumbers
                where n >= 10
                orderby n
                select n;

            Utility.WriteTitle("Numbers Greater or Equal to 10 - Query Syntax");

            foreach (var n in numbersGreaterOrEqualTo10)
            {
                Utility.WriteMessage(n.ToString(), "", "\n");
            }
        }
    }
}
