using D00_Utility;

namespace D17_CSharpAdvanced_Lambda
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Lambda with delegate
            Utility.WriteTitle("Lambda with delegate");

            LambdaWithDelegate.CalculateWithLambdaAndDelegate();
            #endregion

            #region Lambda with anonymous function
            Utility.WriteTitle("Lambda with anonymous function", "\n\n\n\n\n\n");

            LambdaWithAnonymousFunction.CalculateWithLambdaAndAnonymousFunction();
            #endregion

            Utility.TerminateConsole();

        }

    }

}
        