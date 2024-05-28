using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal interface ICourseIT : ICourse      // um interface a herdar de outro interface -> APENAS para dar a ideia de sequência -> NÃO INTERFERE EM NADA
    {
        #region Properties
        bool Exam {  get; }
        #endregion
    }
}
