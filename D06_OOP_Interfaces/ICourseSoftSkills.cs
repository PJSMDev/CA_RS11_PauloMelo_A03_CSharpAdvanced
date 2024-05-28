using System;

namespace D06_OOP_Interfaces
{
    internal enum Language
    {
        Portuguese,
        English,
        Spanish
    }

    internal interface ICourseSoftSkills
    {
        Language CourseLanguage { get; }
    }
}
