using D00_Utility;

namespace D16_CSharpAdvanced_Events
{

    internal class Program
    {
    
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            ClassEventTest myLesson = new ClassEventTest();

            myLesson.TestEvent();

            Utility.TerminateConsole();

        }

    }

}
