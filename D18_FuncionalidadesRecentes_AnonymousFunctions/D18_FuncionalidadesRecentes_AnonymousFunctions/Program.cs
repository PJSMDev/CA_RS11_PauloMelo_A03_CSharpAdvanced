using D00_Utility;

namespace D18_FuncionalidadesRecentes_AnonymousFunctions
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region 
            Utility.WriteTitle("Anonymous Function");

            ClassAnonymousFunction class01 = new ClassAnonymousFunction();

            class01.RunAnonymousFunction();
            #endregion

            Utility.TerminateConsole();

        }

    }

}
