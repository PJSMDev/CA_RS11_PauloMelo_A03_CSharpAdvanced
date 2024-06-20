namespace D21_SOLID_05_DIP
{

    public interface IPersonRepository
    {

        void AddPerson(Person person);

        Person GetPerson(string firstName, string lastName);


    }

}
