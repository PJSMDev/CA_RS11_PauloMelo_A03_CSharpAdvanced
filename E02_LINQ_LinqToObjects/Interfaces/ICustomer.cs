using E02_LINQ_LinqToObjects.Classes;

namespace E02_LINQ_LinqToObjects.Interfaces
{

    public interface ICustomer
    {

        #region Properties

        string Name { get; }
        City Location { get; }      // Simular a relação de dependência entre a classe e a classe City (n->1)
        int Age { get; }

        #endregion
    }
}
