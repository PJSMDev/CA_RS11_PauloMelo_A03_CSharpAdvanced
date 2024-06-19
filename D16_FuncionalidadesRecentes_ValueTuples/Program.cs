using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_FuncionalidadesRecentes_ValueTuples
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            DateTime data = new DateTime(2024, 6, 15);

            #region Value tuple simples

            var student01 = ("Milena", 56, "SFM", new DateTime(2024, 6, 15), false);
            var student02 = (Nome: "Milena", Idade: 56, Localidade: "SFM", DataInscricao: new DateTime(2024, 6, 15), Certificacao: false);
            var student03 = student02;

            student03.Nome = "Amélia";

            Utility.WriteMessage($"Olá {student01.Item1}", "", "\n");
            Utility.WriteMessage($"Tchau {student02.Nome}", "", "\n");
            Utility.WriteMessage($"By {student03.Nome}", "", "\n");

            #endregion

            #region Value tuple - Create

            ValueTuple<string, int, string, DateTime, bool> student04 = ValueTuple.Create("Paulo", 38, "Braga", new DateTime(2024, 6, 15), false);
            (string, int, string, DateTime, bool) student05 = ValueTuple.Create("Paulo", 38, "Braga", new DateTime(2024, 6, 15), false);

            (string, int) student06 = ValueTuple.Create("Paulo", 38);

            MyValueTuple.ListValueTuple(student06);

            var student07 = MyValueTuple.ReturnValueTuple();
            Utility.WriteMessage($"{student07.Item1} {student07.Item2}", "", "\n");

            #endregion

            #region Calculate

            (int, int, int, double) calculations = MyValueTuple.CalculateValueTuple((10, 2));

            Console.WriteLine("Soma: {0}, Subtração: {1}, Produto: {2}, Divisão: {3}", calculations.Item1, calculations.Item2, calculations.Item3, calculations.Item4);

            #endregion

            Utility.TerminateConsole();
        }
    }
}
