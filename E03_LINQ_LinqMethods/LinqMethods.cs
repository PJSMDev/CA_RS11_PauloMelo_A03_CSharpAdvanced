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

        #region
        #endregion

        #region
        #endregion
    }
}
