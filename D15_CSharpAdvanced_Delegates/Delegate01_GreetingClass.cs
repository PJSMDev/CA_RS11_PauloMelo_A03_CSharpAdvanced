using D00_Utility;

namespace D15_CSharpAdvanced_Delegates
{

    internal static class GreetingClass
    {

        internal delegate void Greeting(string name);

        internal static void PortugueseGreeting(string name)
        {

            Utility.WriteMessage($"Olá {name}", "\n");

        }

        internal static void EnglishGreeting(string name)
        {

            Utility.WriteMessage($"Hi {name}", "\n");

        }

        internal static void WriteGreetingClassic(string language, string name)
        {

            if (language == "PT")
            {
                PortugueseGreeting(name);
            }
            else
            {
                EnglishGreeting(name);
            }

        }

        internal static void WriteGreetingDelegate(Greeting greeting, string name)
        {

            greeting(name);

        }

    }

}
