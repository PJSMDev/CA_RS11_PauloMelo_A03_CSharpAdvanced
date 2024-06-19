using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_LINQ
{

    internal class D01_HelloWorld
    {

        #region Method syntax

        internal static void HelloWorldMethodSyntax()
        {

            string[] words =
            {
                "t-sql",
                "hello",
                "linq",
                "beautiful",
                "world"
            };

            #region Execução diferida

            // NOK: string[] shortWords = words.Where(w => w.Length == 5);
            // NOK: List<string> shortWords = words.Where(w => w.Length == 5);

            // OK: var shortWords = words.Where(w => w.Length == 5);        // data.operator(result => expression)
            // OK: List<string> shorWords = (List<string>)words.Where(w => w.Length == 5
            // OK: System.Collections.generic.IEnumerable<string> shortWords = words.Where(w => w.Length == 5);
            IEnumerable<string> shortWords01 = words.Where(w => w.Length == 5);     // versão a usar

            #endregion

            #region Execução em tempo real

            var shortWords02 = words.Where(w => w.Length == 5).Select(w => w.ToUpper());

            #endregion

            #region Listar

            Utility.WriteTitle("Hello World - Method Syntax - v1: execução diferida");
            
            foreach (var item in shortWords01)
            {
                Utility.WriteMessage(item.ToUpper(), "", "\n");
            }

            Utility.WriteMessage("\n");

            Utility.WriteTitle("Hello World - Method Syntax - v2: execução em tempo real");

            foreach (var item in shortWords01)
            {
                Utility.WriteMessage(item.ToUpper(), "", "\n");
            }


            #endregion

        }
        #endregion

        #region Query syntax

        internal static void HelloWorldQuerySyntax()
            {

            string[] words =
{
                "t-sql",
                "hello",
                "linq",
                "beautiful",
                "world"
            };

            var shortWords03 = 
                from w in words
                where w.Length == 5
                select w;       // preciso dizer que quero selecionar w mesmoque seja redundante

            Utility.WriteTitle("Hello World - Query Syntax");

            Utility.WriteMessage("\n");

            foreach (var item in shortWords03)
            {
                Utility.WriteMessage(item.ToUpper(), "", "\n");
            }
        }

            #endregion

    }
}
