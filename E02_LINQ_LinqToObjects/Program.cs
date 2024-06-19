using System;
using D00_Utility;
using E02_LINQ_LinqToObjects.Classes;

namespace E02_LINQ_LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            CityCustomer cityCustomer = new CityCustomer();

            // Criar cidades
            cityCustomer.CreateCitiesCustomers();

            // Adicionar clientes
            cityCustomer.AddCustomers();

            // Consultas LINQ
            Console.WriteLine("2.1. O nome dos clientes da cidade 'Porto':");
            cityCustomer.MethodSyntaxQuestion1();
            Console.WriteLine("\n2.2. O número de clientes da cidade 'Porto':");
            cityCustomer.MethodSyntaxQuestion2();
            Console.WriteLine("\n2.3. O cliente mais novo da cidade 'Porto':");
            cityCustomer.MethodSyntaxQuestion3();
            Console.WriteLine("\n2.4. O nome dos clientes das cidades 'Lisboa' ou 'Paris':");
            cityCustomer.MethodSyntaxQuestion4();
            Console.WriteLine("\n2.5. Uma listagem com o formato 'nome – idade' das pessoas com mais de 18 anos e ordenada pela idade, descendentemente:");
            cityCustomer.MethodSyntaxQuestion5();
            Console.WriteLine("\n2.6. O nome dos clientes e o país de origem:");
            cityCustomer.MethodSyntaxQuestion6();

            Utility.TerminateConsole();
        }
    }
}
