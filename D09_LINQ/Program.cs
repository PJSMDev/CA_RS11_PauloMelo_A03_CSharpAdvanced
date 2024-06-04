using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region D01 - Hello World

            D01_HelloWorld.HelloWorldMethodSyntax();
            D01_HelloWorld.HelloWorldQuerySyntax();

            #endregion

            Utility.WriteMessage("\n");

            #region D02 - Short Names



            #endregion

            #region D03 - Numbers greater or equal to 10

            D01_HelloWorld.HelloWorldQuerySyntax();     

            #endregion

            Utility.TerminateConsole();
        }
    }
}
