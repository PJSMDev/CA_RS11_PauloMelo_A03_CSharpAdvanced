using System.Collections.Generic;

namespace D15_CSharpAdvanced_Delegates
{

    internal static class ExtractNames
    {

        #region Método sem delegate
        public static List<string> ExtractNames_SemDelegate(string[] array, int nameLength)
        {

            var result = new List<string>();

            foreach (var t in array)
                if (t.Length == nameLength)
                    result.Add(t);

            return result;

        }
        #endregion

        #region Método com delegate
        public delegate bool LengthFilter(string item, int length);

        public static bool GreaterThanLengthFilter(string item, int length)
        {

            return item.Length > length;

        }

        public static bool LessThanLengthFilter(string item, int length)
        {

            return item.Length < length;

        }        

        public static List<string> ExtractNames_ComDelegate(LengthFilter filter, string[] array, int length)
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
