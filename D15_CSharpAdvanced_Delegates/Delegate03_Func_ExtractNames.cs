using System;
using System.Collections.Generic;

namespace D15_CSharpAdvanced_Delegates
{

    internal static class Func_ExtractNames
    {

        #region Método com delegate Func
        // internal static delegate bool LengthFilter(string item, int length);  // Substituido pelo Func

        public static bool GreaterThanLengthFilter(string item, int length)
        {

            return item.Length > length;

        }

        public static bool LessThanLengthFilter(string item, int length)
        {

            return item.Length < length;

        }

        public static List<string> ExtractNames_ComDelegateFunc(Func<string, int, bool> filter, string[] array, int length)
        {

            var result = new List<string>();

            foreach (var t in array)
                if (filter(t, length))
                    result.Add(t);

            return result;

        }
        #endregion

    }

}
