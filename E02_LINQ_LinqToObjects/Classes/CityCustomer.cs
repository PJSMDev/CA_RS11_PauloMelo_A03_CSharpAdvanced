using System.Collections;
using System.Collections.Generic;
using System.Linq;
using D00_Utility;

namespace E02_LINQ_LinqToObjects.Classes
{
    internal class CityCustomer
    {
        private List<City> listCities = new List<City>();
        private List<Customer> listCustomers = new List<Customer>();
        private IEnumerable listFiltered;

        internal void CreateCitiesCustomers()
        {
            listCities.Add(new City { Location = "Porto", Country = "Portugal" });
            listCities.Add(new City { Location = "Londres", Country = "Inglaterra" });
            listCities.Add(new City { Location = "Paris", Country = "França" });
            listCities.Add(new City { Location = "Lisboa", Country = "Portugal" });
        }

        internal void AddCustomers()
        {
            listCustomers.Add(new Customer { Name = "Amália", Location = listCities.FirstOrDefault(l => l.Location == "Porto"), Age = 35 });
            listCustomers.Add(new Customer { Name = "John", Location = listCities.FirstOrDefault(l => l.Location == "Londres"), Age = 35 });
            listCustomers.Add(new Customer { Name = "Carlos", Location = listCities.FirstOrDefault(l => l.Location == "Porto"), Age = 53 });
            listCustomers.Add(new Customer { Name = "Lucy", Location = listCities.FirstOrDefault(l => l.Location == "Paris"), Age = 21 });
            listCustomers.Add(new Customer { Name = "Xavier", Location = listCities.FirstOrDefault(l => l.Location == "Lisboa"), Age = 14 });
        }

        internal void MethodSyntaxQuestion1()
        {
            listFiltered = listCustomers.Where(c => c.Location.Location == "Porto").Select(c => c.Name);
            ListCitiesCustomers();
        }

        internal void MethodSyntaxQuestion2()
        {
            int count = listCustomers.Count(c => c.Location.Location == "Porto");
            Utility.WriteMessage(count.ToString(), "", "\n");
        }

        internal void MethodSyntaxQuestion3()
        {
            var youngestCustomer = listCustomers.Where(c => c.Location.Location == "Porto").OrderBy(c => c.Age).FirstOrDefault();
            Utility.WriteMessage($"{youngestCustomer.Name} - {youngestCustomer.Age}", "", "\n");
        }

        internal void MethodSyntaxQuestion4()
        {
            listFiltered = listCustomers.Where(c => c.Location.Location == "Lisboa" || c.Location.Location == "Paris").Select(c => c.Name);
            ListCitiesCustomers();
        }

        internal void MethodSyntaxQuestion5()
        {
            listFiltered = listCustomers.Where(c => c.Age > 18).OrderByDescending(c => c.Age).Select(c => $"{c.Name} - {c.Age}");
            ListCitiesCustomers();
        }

        internal void MethodSyntaxQuestion6()
        {
            listFiltered = listCustomers.Select(c => $"{c.Name} - {c.Location.Country}");
            ListCitiesCustomers();
        }

        internal void ListCitiesCustomers()
        {
            foreach (var item in listFiltered)
            {
                Utility.WriteMessage($"\t{item}", "", "\n");
            }
        }
    }
}