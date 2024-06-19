using System;
using D00_Utility;

namespace D16_CSharpAdvanced_Events
{

    // Subscriber (ou listener)
    internal class ClassEventTest
    {

        internal void TestEvent()
        {

            // 1. Instanciar a classe do evento
            ClassEvent classEvent = new ClassEvent();

            // 2. Subscrever o evento, apontando para o método
            classEvent.MyLesson += MyTestEvent;

        }

        public void MyTestEvent(object sender, EventArgs e)
        {

            // Ex: logar numa bd ou num ficheiro

            // Utility.WriteMessage("O evento disparou!");

        }

    }

}
