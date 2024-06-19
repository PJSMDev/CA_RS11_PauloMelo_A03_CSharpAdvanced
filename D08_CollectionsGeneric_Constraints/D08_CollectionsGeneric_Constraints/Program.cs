using D00_Utility;

namespace D08_CollectionsGeneric_Constraints
{

    internal class Program
    {

        static void Main(string[] args)
        {

            D00_Utility.Utility.SetUnicodeConsole();

            var stringTest = new ReferenceTypeConstraint<string>("Olá turma!");

            D00_Utility.Utility.WriteMessage(stringTest.GetItem());

            // Descomentar a linha de baixo dá erro. Porquê?
            // var intTest = new ReferenceTypeConstraint<int>(123);

            D00_Utility.Utility.TerminateConsole();

        }

    }

}
