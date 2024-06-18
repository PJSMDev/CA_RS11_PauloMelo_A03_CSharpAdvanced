using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_CSharpAdvanced_Async
{
    internal class ClassAsync02
    {

        internal static async Task DoAsyncTask(string task, int delay) 
        {

            Console.WriteLine($"Início da {task}\n\n");

            await Task.Delay(delay);

            Console.WriteLine($"Fim da {task} com o delay de {delay} milissegundos\n\n");
        }
    }
}
