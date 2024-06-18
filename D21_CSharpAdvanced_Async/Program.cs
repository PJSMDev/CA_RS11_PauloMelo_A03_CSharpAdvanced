using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_CSharpAdvanced_Async
{

    internal class Program
    {

        static async Task Main(string[] args)     // main thread -> async
        {

            #region Async01

            //// Começar as 2 tarefas
            //Task task01 = ClassAsync01.Task01();        // Isto é uma invocação e não instanciação
            //Task task02 = ClassAsync01.Task02();

            //// Aguardar pelas tarefas terminarem
            //await Task.WhenAll(task01, task02);

            //Console.WriteLine("Tarefas terminadas");

            #endregion

            #region Async02

            // Começar as 2 tarefas
            Task task03 = ClassAsync02.DoAsyncTask("task03", 3000);
            Task task04 = ClassAsync02.DoAsyncTask("task04", 2000);

            // Aquardar pelas tarefas terminarem
            await Task.WhenAll(task03, task04);

            Console.WriteLine("Tarefas terminadas");
            #endregion

            Console.ReadKey();
        }
    }
}
