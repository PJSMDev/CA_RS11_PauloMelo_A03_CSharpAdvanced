using D00_Utility;

namespace D19_FuncionalidadesRecentes_LocalFunctions
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region 
            Utility.WriteTitle("Local Function");

            ClassLocalFunction.Write("C#");

            // ClassLocalFunction.WriteClassic("C#", ".");
            // ClassLocalFunction.WriteClassic("C#", "*");

            #endregion

            Utility.TerminateConsole();

        }

    }

}
