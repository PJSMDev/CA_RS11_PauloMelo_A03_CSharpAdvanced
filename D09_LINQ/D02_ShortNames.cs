// Listar os nomes mais curtos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

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
            D00_Utility.Utility.WriteMessage(item, "", "\n\n");
        }
    }

    internal static void ShortNamesQuerySyntax() 
    {

            // Método a usar
            #region v1: Com subquery e Min()

            var shortNames01 =
                from l1 in listNames
                where l1.Length ==
                (
                    from l2 in listNames
                    select l2.Length
                ).Min()
                select l1;

            Utility.WriteTitle("Short Names - Query Syntax - v1");

            foreach (var item in shortNames01)
            {
                D00_Utility.Utility.WriteMessage(item, "", "\n");
            }

            #endregion

            #region v2: Com subquery e First()

            var shortNames02 =
                from l1 in listNames
                where l1.Length ==
                (
                    from l2 in listNames
                    orderby l2.Length
                    select l2.Length
                ).First()
                select l1;

            Utility.WriteTitle("Short Names - Query Syntax - v2");

            foreach (var item in shortNames02)
            {
                D00_Utility.Utility.WriteMessage(item, "", "\n");
            }

            #endregion

            // Método a evitar
            #region v3: Sem subquery e Min() em method syntax

            var shortNames03 =
                from l1 in listNames
                where l1.Length == listNames.Min(n2 => n2.Length)
                select l1;

            Utility.WriteTitle("Short Names - Query Syntax e Method Syntax - v3");

            foreach (var item in shortNames03)
            {
                D00_Utility.Utility.WriteMessage(item, "", "\n");
            }

            #endregion

        }
}
}
