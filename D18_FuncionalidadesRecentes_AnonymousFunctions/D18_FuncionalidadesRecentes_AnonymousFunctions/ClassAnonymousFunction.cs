using D00_Utility;

namespace D18_FuncionalidadesRecentes_AnonymousFunctions
{

    internal class ClassAnonymousFunction
    {

        delegate void AnonymousFunctionDelegate(string mensagem);

        internal void RunAnonymousFunction()
        {

            // Criar o método anónimo com lambda, usando o delegate
            AnonymousFunctionDelegate AnonymousFunction = (string message) =>
            {
                Utility.WriteMessage($"Função anónima executada com a mensagem: {message}");
            };

            // Chamar
            AnonymousFunction("C# Sharp");

        }

    }

}
