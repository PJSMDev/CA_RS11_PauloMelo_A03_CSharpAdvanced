using E01_OOP_Vehicle_PauloMelo_v03.Interfaces;
using D00_Utility;
using System;

namespace E01_OOP_Vehicle_PauloMelo_v03.Classes
{
    public class Submarine : Vehicle, IVehicleWater
    {
        #region Properties
        public new Enums.SubmarineMake Make { get; set; }
        public new Enums.SubmarineModel Model { get; set; }
        public string PennantNumber { get; set; }
        public Enums.SubmarineType Type { get; set; }
        public int CurrentDepth { get; set; }
        public int MaxDepth { get; set; }
        #endregion

        #region Methods
        public override void Create()
        {
            base.Create();
            Utility.WriteMessage("Submarino criado.", "", "\n\n");

            Utility.WriteMessage("Introduza número de bandeira: ");
            PennantNumber = Console.ReadLine();

            Utility.WriteMessage("Introduza marca (0 para Trident, 1 para Typhoon): ");
            Make = (Enums.SubmarineMake)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza modelo (0 para TridentJuno, 1 para TridentI, 2 para TyphoonClass): ");
            Model = (Enums.SubmarineModel)int.Parse(Console.ReadLine());

            Utility.WriteMessage("Introduza classe (0 para Militar, 1 para Pesquisa, 2 para Turismo): ");
            Type = (Enums.SubmarineType)int.Parse(Console.ReadLine());

            Console.Write("Introduza profundidade máxima: ");
            MaxDepth = int.Parse(Console.ReadLine());
        }

        public override void Move()
        {
            Utility.WriteMessage("Submarino em movimento.");
        }

        public void Dive()
        {
            Utility.WriteMessage("Submarino a submergir.");
            Console.Write("Introduza profundidade: ");
            int depth = int.Parse(Console.ReadLine());
            if (depth <= MaxDepth)
            {
                CurrentDepth = depth;
                Utility.WriteMessage($"Submarino submergiu {CurrentDepth} metros.");
            }
            else
            {
                Utility.WriteMessage("Profundidade excede profundidade máxima.");
            }
        }

        public void Emerge()
        {
            Utility.WriteMessage("Submarino a emergir.");
            CurrentDepth = 0;
        }
        #endregion
    }
}
