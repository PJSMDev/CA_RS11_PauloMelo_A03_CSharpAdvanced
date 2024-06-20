namespace D20_FuncionalidadesRecentes_Discards
{

    internal class Person
    {

        // Deconstruir o tuple é o mecanismo de ler os seus valores

        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructor
        public Person()
        {

            Name = "M";
            Surname = "RS";
            City = "SFM";
            Email = "mrs@mail.com";

        }
        #endregion

        #region Deconstructor
        // O método descontrutor tem de se chamar Deconstruct
        // Este método tem na sua assinatura os out parameters
        internal void Deconstruct(out string name, out string surname, out string city, out string email)
        {

            // A utilização de out parameters no método é uma alternativa a fazer return com tuple

            name = Name;
            surname = Surname;
            city = City;
            email = Email;

        }

        // Function (método não void) com tuple
        internal (string, string, string, string) Return()
        {

            // return (Name, Surname, city, email);    // Não posso ter um tuple de propriedades, nem de variáveis

            return ("M", "RS", "SFM", "mrs@mail.pt");   // tuple de valores

        }
        #endregion

    }

}
