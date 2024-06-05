using E02_LINQ_LinqToObjects.Classes;

namespace E02_LINQ_LinqToObjects.Interfaces
{

    public interface ICity
    {

        #region Properties

        string Location { get; set; }
        string Country { get; set; }

        #endregion
    }
}
