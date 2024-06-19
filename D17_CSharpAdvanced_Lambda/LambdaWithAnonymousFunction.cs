using D00_Utility;
using System;

namespace D17_CSharpAdvanced_Lambda
{

    internal static class LambdaWithAnonymousFunction
    {

        internal static void CalculateWithLambdaAndAnonymousFunction()
        {

            // Substituir o delegate por Func<T, TResult>

            // Com expressão lambda
            Func<int, int, int> add = (a, b) => a + b;

            // Com função anónima (a função anónima tem de ser do tipo delegate)
            Func<int, int, int> subtract = delegate (int a, int b)
            {

                return a - b;

            };

            // Operação com a expressão lambda
            int resultAdd = Calculate(add, 5, 3);

            // Operação com função anónima
            int resultSubtract = Calculate(subtract, 8, 4);

            // Resultados
            Utility.WriteMessage("Somar: " + resultAdd, "", "\n\n");
            Utility.WriteMessage("Subtrair: " + resultSubtract);

        }

        // Método para calcular que recebe um delegate Func como parâmetro
        internal static int Calculate(Func<int, int, int> operation, int x, int y)
        {

            return operation(x, y);     // Value tuple

        }

    }

}
