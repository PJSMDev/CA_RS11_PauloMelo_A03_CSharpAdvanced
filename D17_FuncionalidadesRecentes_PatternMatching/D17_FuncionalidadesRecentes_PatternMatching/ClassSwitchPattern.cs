using D00_Utility;

namespace D17_FuncionalidadesRecentes_PatternMatching
{

    internal class ClassSwitchPattern
    {

        internal static void TellMeTheType(object x)
        {

            switch (x)
            {

                case int i:
                    Utility.WriteMessage("É um inteiro", "\n\n");
                    Utility.WriteMessage($"O quadrado de {i} = {i * i}", "\n\n");
                    break;
                
                case string s:
                    Utility.WriteMessage("É uma string", "\n\n");
                    Utility.WriteMessage($"O comprimento da string {s} = {s.Length}", "\n\n");
                    break;
                
                default:
                    Utility.WriteMessage("Não sei qual o tipo de x", "\n\n");
                    break;

            }

        }

    }

}
