using D00_Utility;
using System;

namespace D16_CSharpAdvanced_Events
{

    // Publisher
    internal class ClassEvent
    {

        #region Delegate do evento
        public delegate void MyEventHandler(object sender, EventArgs e);
        #endregion

        #region Evento
        public event MyEventHandler MyLesson
        {

            // Início do evento (+=)
            add
            {
                Utility.WriteMessage("Lesson is starting.");
            }

            // Fim do evento
            remove
            {
                Utility.WriteMessage("Lesson has finished.");
            }

        }
        #endregion

    }

}
