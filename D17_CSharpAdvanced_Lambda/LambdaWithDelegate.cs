using D00_Utility;

namespace D17_CSharpAdvanced_Lambda
{

    internal static class LambdaWithDelegate
    {

        // Delegate
        internal delegate int MathOperation(int x, int y);

        internal static void CalculateWithLambdaAndDelegate()
        {

            // Expressão lambda com o delegate
            MathOperation add = (int a, int b) => a + b;
            MathOperation subtract = (int a, int b) => a - b;
            MathOperation multiply = (int a, int b) => a * b;
            MathOperation divide = (int a, int b) => a / b;

            // Operações com as expressões lambda
            int resultAdd = Calculate(add, 5, 3);
            int resultSubtract = Calculate(subtract, 8, 4);
            int resultMultiply = Calculate(multiply, 10, 2);
            int resultDivide = Calculate(divide, 100, 50);

            // Resultados
            Utility.WriteMessage($"Somar: {resultAdd}", "", "\n\n");
            Utility.WriteMessage($"Subtrair: {resultSubtract}", "", "\n\n");
            Utility.WriteMessage($"Multiplicar: {resultMultiply}", "", "\n\n");
            Utility.WriteMessage($"Dividir: {resultDivide}");

        }

        // Método para calcular que recebe um delegate como parâmetro
        internal static int Calculate(MathOperation operation, int x, int y)
        {

            return operation(x, y);     // Devolver 1 tuple com 2 items

        }

    }

}
