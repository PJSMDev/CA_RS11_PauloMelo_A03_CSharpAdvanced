using D00_Utility;
using E01_OOP_Vehicle_PauloMelo_v03.Interfaces;
using System;

namespace E01_OOP_Vehicle_PauloMelo_v03.Classes
{
    public abstract class Vehicle : IVehicle
    {
        #region Instances
        private static int idCounter = 0;
        #endregion

        #region Properties
        public int Id { get; }
        public int Year { get; set; }
        public Enum Make { get; set; }
        public Enum Model { get; set; }
        #endregion

        #region Methods
        protected Vehicle()
        {
            Id = ++idCounter;
        }

        public virtual void Create()
        {
            Utility.WriteMessage("Veículo em processo de criação.", "", "\n");
            Utility.WriteMessage("Ano: ");
            Year = int.Parse(Console.ReadLine());
        }

        public virtual void Start()
        {
            Utility.WriteMessage("Iniciando veículo.");
        }

        public abstract void Move();

        public virtual void Stop()
        {
            Utility.WriteMessage("Parando veículo.");
        }
        #endregion
    }
}