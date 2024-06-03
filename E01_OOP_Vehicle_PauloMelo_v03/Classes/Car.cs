using E01_OOP_Vehicle_PauloMelo_v03.Interfaces;
using D00_Utility;
using System;

namespace E01_OOP_Vehicle_PauloMelo_v03.Classes
{
    public class Car : Vehicle, IVehicleRoad
    {
        #region Properties
        public new Enums.CarMake Make { get; set; }
        public new Enums.CarModel Model { get; set; }
        public string CarRegistration { get; set; }
        public Enums.Color Color { get; set; }
        public Enums.NumberOfDoors NumberOfDoors { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        #endregion

        #region Methods
        public override void Create()
        {
            base.Create();
            Utility.WriteMessage("Carro criado.", "", "\n\n");

            Utility.WriteMessage("Introduza matrícula: ");
            CarRegistration = Console.ReadLine();

            Utility.WriteMessage("Introduza marca (0 para Ford, 1 para Seat): ");
            Make = (Enums.CarMake)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza modelo (0 para Fiesta, 1 para Escort, 2 para Ibiza): ");
            Model = (Enums.CarModel)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza cor (0 para Vermelho, 1 para Azul, 2 para Preto, 3 para Branco, 4 para Verde): ");
            Color = (Enums.Color)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Número de portas (0 para Duas, 1 para Quatro, 2 para Cinco): ");
            NumberOfDoors = (Enums.NumberOfDoors)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Velocidade máxima: ");
            MaxSpeed = int.Parse(Console.ReadLine());
        }

        public override void Move()
        {
            Utility.WriteMessage("O carro move-se a 50 km/h.");
            CurrentSpeed = 50;
        }

        public void Move(int speed)
        {
            if (speed <= MaxSpeed)
            {
                Utility.WriteMessage($"O carro move-se a {speed} km/h.");
                CurrentSpeed = speed;
            }
            else
            {
                Utility.WriteMessage("Velocidade atual excede velocidade máxima.");
            }
        }

        public void Park()
        {
            Utility.WriteMessage("Carro estacionado.");
            CurrentSpeed = 0;
        }

        public void Honk()
        {
            Utility.WriteMessage("Carro a buzinar.");
        }
        #endregion
    }
}