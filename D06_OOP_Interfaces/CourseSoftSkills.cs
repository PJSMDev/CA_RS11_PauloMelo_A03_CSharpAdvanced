using System;

namespace D06_OOP_Interfaces
{
    internal class CourseSoftSkills : ICourseSoftSkills
    {
        #region Properties

        public Language CourseLanguage { get; set; }

        #endregion

        #region Constructors

        public CourseSoftSkills(Language language)
        {
            CourseLanguage = language;
        }

        #endregion

        #region Methods

        #endregion
    }
}
