using D00_Utility;
using D20_FuncionalidadesRecentes_Discards;

namespace D26_FuncionalidadesRecentes_Discards
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Discard com Tuples
            Utility.WriteTitle("Discard com Tuples");

            var cidades = ("Lisboa", "Porto", "Espinho");   // tuple com 3 items

            var (latitude01, _) = Coordinates.GetCoordinates(cidades.Item1);
            Utility.WriteMessage($"Latitude de {cidades.Item1} é {latitude01}.", "\n", "\n\n");

            var (_, longitude01) = Coordinates.GetCoordinates(cidades.Item2);
            Utility.WriteMessage($"Longitude do {cidades.Item2} é {longitude01}.", "", "\n\n");

            var (latitude02, longitude02) = Coordinates.GetCoordinates(cidades.Item3);
            Utility.WriteMessage($"Longitude de {cidades.Item3} é {latitude02}, {longitude02}.", "", "\n\n");
            #endregion

            #region Discard e Deconstructor
            Utility.WriteTitle("Discard e Deconstructor", "\n\n\n\n\n\n");

            var person1 = new Person();
            var (name1, surname1, city1, email1) = person1;     // Aceder ao deconstructor
            Utility.WriteMessage($"Hello person1: {name1} {surname1} of {city1} with email {email1}!", "\n", "\n\n");

            var person2 = new Person();
            var (name2, _, city2, _) = person2;     // Para omitir os parameters do deconstruct, usar discards
            Utility.WriteMessage($"Hello person2: {name2} of {city2}!", "", "\n\n");

            var person3 = new Person();
            var (name3, surname3, _, _) = person3;
            Utility.WriteMessage($"Hello person3: {name3} {surname3}!", "", "\n\n");

            // Usar o tuple devolvido de Return()
            var person4 = new Person();
            var (name4, _, city4, _) = person4.Return();
            Utility.WriteMessage($"Hello person4: {name4}!", "", "\n\n");
            #endregion

            Utility.TerminateConsole();

        }

    }

}
