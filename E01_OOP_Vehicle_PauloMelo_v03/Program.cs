using D00_Utility;
using E01_OOP_Vehicle_PauloMelo_v03.Classes;
using System;
using System.Collections.Generic;

namespace E01_OOP_Vehicle_PauloMelo_v03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Set Console
            Utility.SetUnicodeConsole();
            #endregion

            #region Instances
            List<Vehicle> vehicles = new List<Vehicle>();
            #endregion

            #region Fluxo
            while (true)
            {
                Utility.WriteTitle("OOP C# – Exercício 'Vehicle'");
                Utility.WriteMessage("Selecione o veículo:", "", "\n\n");
                Utility.WriteMessage("1. Avião", "", "\n");
                Utility.WriteMessage("2. Carro", "", "\n");
                Utility.WriteMessage("3. Submarino", "", "\n");
                Utility.WriteMessage("4. Sair", "", "\n\n");
                Utility.WriteMessage("Escolha : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    Utility.TerminateConsole();
                    break;
                }

                Vehicle vehicle = null;

                switch (choice)
                {
                    case 1:
                        vehicle = new Airplane();
                        break;
                    case 2:
                        vehicle = new Car();
                        break;
                    case 3:
                        vehicle = new Submarine();
                        break;
                    default:
                        Utility.WriteMessage("Escolha inválida. Tente Novamente.", "\n", "\n\n");
                        continue;
                }

                vehicle.Create();
                vehicles.Add(vehicle);

                Utility.WriteMessage("\n");
            }
            #endregion
        }
    }
}
