using D00_Utility;
using System.Collections.Generic;

namespace D07_CollectionsGeneric_IEnumerable
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            NumberGenerator numberGenerator01 = new NumberGenerator();

            #region IEnumerable<T>
            IEnumerable<int> enumerableNumbers = numberGenerator01.GetNumbers_IEnumerable(3);
            
            D00_Utility.Utility.WriteTitle("IEnumerable<T>");
            
            foreach (var number in enumerableNumbers)
            {
                Utility.WriteMessage(number.ToString(), "", "\n");
            }
            #endregion

            D00_Utility.Utility.WriteMessage("\n\n");

            #region IList<T>
            IList<int> listNumbers = numberGenerator01.GetNumbers_IList(3);

            D00_Utility.Utility.WriteTitle("IList<T>");
            
            foreach (var number in listNumbers)
            {
                Utility.WriteMessage(number.ToString(), "", "\n");
            }
            #endregion

            Utility.TerminateConsole();

        }

    }

}
