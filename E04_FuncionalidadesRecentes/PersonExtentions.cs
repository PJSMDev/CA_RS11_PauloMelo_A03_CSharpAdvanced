namespace E04_FuncionalidadesRecentes
{
    public static class PersonExtensions
    {
        #region Extension Methods

        public static string GetFullName(this Person person)
        {
            return person.Name;
        }

        #endregion
    }
}
