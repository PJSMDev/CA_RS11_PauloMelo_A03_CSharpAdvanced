using System;

namespace D03_OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Certifique-se de usar o nome correto da classe derivada
            ClassIT myClass = new ClassIT(1, "Programming", "IT", true);
            myClass.ListCourse();
        }
    }
}
