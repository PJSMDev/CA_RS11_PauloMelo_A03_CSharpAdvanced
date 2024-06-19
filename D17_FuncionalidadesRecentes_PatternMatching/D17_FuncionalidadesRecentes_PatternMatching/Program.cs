using D00_Utility;

namespace D17_FuncionalidadesRecentes_PatternMatching
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Pattern Matching");

            ClassSwitchPattern.TellMeTheType(12);          // É um inteiro
                                                           // O quadrado de 12 = 144  

            ClassSwitchPattern.TellMeTheType("hello");     // É uma string
                                                           // O comprimento da string hello = 5

            ClassSwitchPattern.TellMeTheType(true);        // Não sei qual o tipo de x

            Utility.TerminateConsole();

        }

    }

}
