namespace D21_SOLID_05_DIP
{

    public class FullNameFormatter : INameFormatter
    {
     
        public string FormatName(Person person)
        {
        
            return $"{person.FirstName} {person.LastName}";

        }

    }

}
