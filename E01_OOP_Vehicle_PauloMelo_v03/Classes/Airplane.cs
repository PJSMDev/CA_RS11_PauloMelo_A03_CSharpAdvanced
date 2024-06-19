using D00_Utility;
using E01_OOP_Vehicle_PauloMelo_v03.Interfaces;
using System;

namespace E01_OOP_Vehicle_PauloMelo_v03.Classes
{
    public class Airplane : Vehicle, IVehicleAir
    {
        #region Properties
        public new Enums.AirplaneMake Make { get; set; }
        public new Enums.AirplaneModel Model { get; set; }
        public string PlaneRegistration { get; set; }
        public Enums.AirplaneType Type { get; set; }
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        #endregion

        #region Methods
        public override void Create()
        {
            base.Create();
            Utility.WriteMessage("Avião criado.", "", "\n\n");

            Utility.WriteMessage("Registo do avião: ");
            PlaneRegistration = Console.ReadLine();

            Utility.WriteMessage("Introduza marca (0 para Boeing, 1 para Airbus): ");
            Make = (Enums.AirplaneMake)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza modelo (0 para Boeing737, 1 para Boeing747, 2 para AirbusA320): ");
            Model = (Enums.AirplaneModel)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza a classe (0 para Comercial, 1 para Carga, 2 para Militar, 3 para Executiva, 4 para Treino/Formação): ");
            Type = (Enums.AirplaneType)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza Altitude máxima: ");
            MaxAltitude = int.Parse(Console.ReadLine());
        }

        public override void Move()
        {
            Utility.WriteMessage("Avião em movimento.");
        }

        public void TakeOff()
        {
            Utility.WriteMessage("Avião a descolar.");
            CurrentAltitude = MaxAltitude;
        }

        public void Land()
        {
            Utility.WriteMessage("Avião a aterrar.");
            CurrentAltitude = 0;
        }
        #endregion
    }
}