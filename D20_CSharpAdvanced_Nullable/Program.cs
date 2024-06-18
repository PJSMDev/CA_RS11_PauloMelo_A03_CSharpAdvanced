using D00_Utility;

namespace D20_CSharpAdvanced_Nullable
{

    internal class Program
    {

        // Nullable é para value types

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            // v1: NOK
            // Erro de sintaxe: cannot convert null to 'int' because it is a non-nullable value type
            // int x = null;

            // v2: OK
            // Nullable<int> x = null;

            // v3: OK simplificado
            int? nullableInt = null;
            bool? nullableBool = null;
            float? nullableFloat = null;
            // string? nullableString = null;       // erro: string é um reference type

            Utility.WriteTitle("nullable value types");

            Utility.WriteMessage($"Nullable int (v0): {nullableInt}", "\n");                        // vazio            
            Utility.WriteMessage($"Nullable int: {nullableInt.GetValueOrDefault()}", "\n");         // 0
            Utility.WriteMessage($"Nullable bool: {nullableBool.GetValueOrDefault()}", "\n");       // false
            Utility.WriteMessage($"Nullable float: {nullableFloat.GetValueOrDefault()}");           // 0

            Utility.TerminateConsole();

        }

    }

}
