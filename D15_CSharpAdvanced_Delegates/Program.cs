using D00_Utility;

namespace D15_CSharpAdvanced_Delegates
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region GREETING: método clássico, sem delegate
            /*
            Utility.WriteTitle("GREETING: método clássico, sem delegate");

            GreetingClass.WriteGreetingClassic("PT", "Milena");

            GreetingClass.WriteGreetingClassic("EN", "Milena");
            */
            #endregion

            #region GREETING: método com delegate
            /*
            Utility.WriteTitle("GREETING: método com delegate", "\n\n\n\n");

            GreetingClass.WriteGreetingDelegate(GreetingClass.PortugueseGreeting, "Milena");

            GreetingClass.WriteGreetingDelegate(GreetingClass.EnglishGreeting, "Milena");
            */
            #endregion

            #region EXTRACT NAMES: método com delegate
            string[] namesDelegate = 
            { 
                "Alice",
                "John",
                "Bobby",
                "Kyle",
                "Scott",
                "Tod",
                "Sharon",
                "Ann",
                "George"
            };

            Utility.WriteTitle("EXTRACT NAMES: método com delegate");

            Utility.WriteMessage(string.Join(", ", ExtractNames.ExtractNames_ComDelegate(ExtractNames.GreaterThanLengthFilter, namesDelegate, 5)));

            Utility.WriteMessage(string.Join(", ", ExtractNames.ExtractNames_ComDelegate(ExtractNames.LessThanLengthFilter, namesDelegate, 5)), "\n\n\n");
            #endregion

            #region EXTRACT NAMES: método com Func<T, TResult>
            string[] namesFunc = 
            { 
                "Alice",
                "John",
                "Bobby",
                "Kyle",
                "Scott",
                "Tod",
                "Sharon",
                "Ann",
                "George"
            };

            Utility.WriteTitle("EXTRACT NAMES: método com Func<T, TResult>", "\n\n\n\n\n");

            Utility.WriteMessage(string.Join(", ", Func_ExtractNames.ExtractNames_ComDelegateFunc(ExtractNames.GreaterThanLengthFilter, namesFunc, 5)));

            Utility.WriteMessage(string.Join(", ", Func_ExtractNames.ExtractNames_ComDelegateFunc(ExtractNames.LessThanLengthFilter, namesFunc, 5)), "\n\n\n");
            #endregion

            Utility.TerminateConsole();

        }

    }

}
