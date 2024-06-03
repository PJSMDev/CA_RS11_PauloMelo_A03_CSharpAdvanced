namespace D06_OOP_Interfaces
{
    internal interface ICourseSoftSkills : ICourse
    {
        #region Properties

        EnumLanguage CourseLanguage { get; }

        #endregion
    }
}
