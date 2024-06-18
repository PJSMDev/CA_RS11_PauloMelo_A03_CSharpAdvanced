using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_LINQ_LinqMethods
{

    internal class LinqMethods
    {

        #region Lista

        internal List<TimeSpan> timeSpanList = new List<TimeSpan>();

        #endregion

        #region Criar uma lsita de 10 timespans aleatórios entre 0 e 24

        internal void CreateListTimespan()
        {

            Random random = new Random();

            TimeSpan start = TimeSpan.FromHours(0);
            TimeSpan end = TimeSpan.FromHours(24);

            // Calcular os minutos para servir de cálculo às horas
            int maxMinutes = (int)(end - start).TotalMinutes;

            for (int i = 0; i < 10; ++i)
            {
                int minutes = random.Next(maxMinutes);
                timeSpanList.Add(start.Add(TimeSpan.FromMinutes(minutes)));
            }

        }

        #endregion

        #region Listar timespans

        internal void ListTimespans()
        {

            Utility.WriteTitle("Lista de timespans");

            foreach (var item in timeSpanList)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            }
        }

        #endregion

        #region Usar FindAll() para localizar todas as timespans inferiores a 12 horas

        internal void FindAllTimespans()
        {
            var ex1 = timeSpanList.FindAll(t => t < new TimeSpan(12, 0, 0));
            // var ex1 = timeSpanList.FindAll(t => t.Hours < 12);

            Utility.WriteMessage("1. FindAll(): localizar todas as timespans inferiores a 12 horas", "", "\n");

            foreach (TimeSpan t in ex1)
            {
                Utility.WriteMessage($"\t{t}", "", "\n");
            }
        }

        #endregion

        #region Usar Exists() para verificar se exuste alguma timespan tiver 5 na propriedade Hours


        //   var list = timeSpanList.Exists(t => t.Hours == 5);

        // if

        #endregion

        #region

        internal void True()
        {


        }

        #endregion
    }
}
