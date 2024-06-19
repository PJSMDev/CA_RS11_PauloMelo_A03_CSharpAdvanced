using D00_Utility;

namespace D19_FuncionalidadesRecentes_LocalFunctions
{

    internal class ClassLocalFunction
    {

        internal static void Write(string message)
        {

            WriteLeftPad('.');
            WriteLeftPad('*');

            void WriteLeftPad(char character)
            {

                const int tabLength = 6;

                var pad = "".PadLeft(tabLength, character);

                Utility.WriteMessage($"{pad} {message} {pad}", "\n\n");

            }

        }

        /*
        internal static void WriteClassic(string message, string character)
        {

            const int tabLength = 6;
               
            var pad = "".PadLeft(tabLength, character);

            Utility.WriteMessage($"{pad} {message} {pad}", "\n\n");

        }
        */

    }

}
