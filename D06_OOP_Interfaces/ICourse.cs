using System;

namespace D06_OOP_Interfaces
{
    internal interface ICourse
    {

        #region Properties

        int CourseId { get; }
        string Name {  get; }
        string FullCouse { get; }

        #endregion

        #region Methods

        void ReadCourse();
        void ListCourse(string level);
        void ListCourse(DateTime timestamp);

        #endregion
    }
}
