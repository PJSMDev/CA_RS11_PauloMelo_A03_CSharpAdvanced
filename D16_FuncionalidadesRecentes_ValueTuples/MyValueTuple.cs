using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_FuncionalidadesRecentes_ValueTuples
{

    internal class MyValueTuple
    {

        internal static void ListValueTuple((string, int) student)
        {

            Utility.WriteMessage($"Nome: {student.Item1}, Idade: {student.Item2}", "", "\n");

            Console.WriteLine("{0} {1}", student.Item1, student.Item2, "", "\n");
        }

        internal static (string, string) ReturnValueTuple()
        {
            return ("Olá", "turma");
        }

        // Calculate
        // 1. receber um tuple de 2 inteiros
        // 2. devolver um tuple de 4 inteiros, com o resultado das 4 operações aritméticas
        // 3. no Program, listar o resultado das 4 operações aritm~eticas
        internal static (int, int, int, double) CalculateValueTuple((int, int) values) 
        {
            //return ((numeros.Item1 + numeros.Item2), (numeros.Item1 - numeros.Item2), (numeros.Item1 * numeros.Item2), (numeros.Item1 / numeros.Item2));

            int resultAdd = values.Item1 + values.Item2;
            int resultSubtract = values.Item1 - values.Item2;
            int resultProduct = values.Item1 * values.Item2;
            int resultDivision = values.Item1 / values.Item2;

            return (resultAdd, resultSubtract, resultProduct, resultDivision);
        }
    }
}
