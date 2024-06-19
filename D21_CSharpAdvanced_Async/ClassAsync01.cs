using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_CSharpAdvanced_Async
{

    internal class ClassAsync01
    {

        internal static async Task Task01()
        {

            Console.WriteLine("Início da task01 \n\n");

            await Task.Delay(2000);     // milissegundos

            Console.WriteLine("Fim da task01 \n\n");        // usa-se Console porque a Utility não tem versões Task dos seus métodos
        }

        internal static async Task Task02()
        {

            Console.WriteLine("Início da task02 \n\n");

            await Task.Delay(4000);     // milissegundos

            Console.WriteLine("Fim da task02 \n\n");
        }
    }
}
