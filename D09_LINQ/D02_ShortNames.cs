// Listar os nomes mais curtos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_LINQ
{

    internal class D02_ShortNames
    {

        static List<string> listNames = new List<string>();

        internal static void CreateListNames()
        {

            listNames.Add("Thiago");
            listNames.Add("Rui");
            listNames.Add("Manuela");
            listNames.Add("Zé");
            listNames.Add("Henrique");
            listNames.Add("Ana");
            listNames.Add("Sá");
            listNames.Add("Francisco");
            listNames.Add("Paula");

        }

        internal static void ShortNamesMethodSyntax()
        {

            // NOK: var shortNames = listNames.Where(l => l.Length == 2);
            // Não está errado mas não é dinâmico e pode causar problemas no futuro, quando usar outras listas

            var shortNames = listNames.Where(l1 => l1.Length == listNames.Min(l2 => l2.Length));
            // equivalente a um SELECT dentro de outro SELECT

            D00_Utility.Utility.WriteTitle("Short Names - Method Syntax");

            D00_Utility.Utility.WriteMessage("\n");

            foreach (var item in shortNames)
            {
                D00_Utility.Utility.WriteMessage(item, "", "\n");
            }
        }

        internal static void ShortNamesQuerySyntax() 
        {
            
            // Método a usar
            #region v1: Com subquery e Min()
            #endregion

            // Método a usar
            #region v2: Com subquery e First()
            #endregion

            // Método a evitar
            #region v3: Sem subquery e Min() em method syntax
            #endregion

            // Minha versão atual -> Mudar!!!
            int minLength = (from name in listNames
                             select name.Length).Min();

            var shortNames =
                from name in listNames
                where name.Length == minLength
                select name;
            
        }
    }
}
