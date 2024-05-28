using System;

namespace D06_OOP_Interfaces
{
    internal class Course : IArea, ICourse     // multi-herança de Interfaces
    {

        #region Properties

        public int CourseId { get; set; }       // todos os membros de um interface têm de ser public

        public int AreaId { get; set; }     

        public string Name { get; set; }

        public string AreaName { get; set; }

        public string SubAreaName { get; set; }

        public string Description { get; set; }

        public string FullCouse { get; set; }

        #endregion

        #region Methods
        public void ListCourse(string level)
        {
            throw new NotImplementedException();
        }

        public void ListCourse(DateTime timestamp)
        {
            throw new NotImplementedException();
        }

        public void ReadCourse()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
