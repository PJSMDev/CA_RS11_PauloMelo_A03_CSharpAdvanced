using D00_Utility;
using System;

namespace D19_CSharpAdvanced_ExtensionMethods
{

    internal class Program
    {

        static void Main(string[] args)
        {

            try
            {

                Utility.SetUnicodeConsole();

                #region Concatenar para maiúsculas
                string t01 = "C";
                string t02 = "Milena";

                Utility.WriteTitle("Concatenar e Maiúsculas");

                Utility.WriteMessage(t01.MyConcatAndUpper("Sharp"));
                Utility.WriteMessage(t02.MyConcatAndUpper("Reis e Sousa"), "\n\n");
                #endregion

                #region Formatar para euro
                int v01 = 1;
                string v02 = "2";
                string v03 = "a";

                Utility.WriteTitle("FormatarParaEuro()", "\n\n\n\n");

                Utility.WriteMessage(v01.MyFormatToEuro());

                Utility.WriteMessage(v02.MyFormatToEuro(), "\n\n");

                Utility.WriteMessage(v03.MyFormatToEuro(), "\n\n");     // Erro
                #endregion

            }
            catch (FormatException)
            {

                Utility.WriteMessage("Formato incorreto do número!", "\n\n\n\n");

            }
            catch (Exception)
            {

                Utility.WriteMessage("Erro!", "\n\n\n\n");

            }            
            finally
            {

                Utility.TerminateConsole();

            }

        }

    }

}
