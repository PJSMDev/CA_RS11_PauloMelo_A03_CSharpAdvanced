namespace E01_OOP_Vehicle_PauloMelo_v03
{
    public static class Enums
    {
        #region Airplane
        public enum AirplaneMake { Boeing, Airbus }
        public enum AirplaneModel { Boeing737, Boeing747, AirbusA320 }
        public enum AirplaneType { Comercial, Carga, Militar, Executivo, Treino }
        #endregion

        #region Car
        public enum CarMake { Ford, Seat }
        public enum CarModel { Fiesta, Escort, Ibiza }
        public enum Color { Vermelho, Azul, Preto, Branco, Verde }
        public enum NumberOfDoors { Duas, Quatro, Cinco }
        #endregion

        #region Submarine
        public enum SubmarineMake { Trident, Typhoon }
        public enum SubmarineModel { TridentJuno, TridentI, TyphoonClass }
        public enum SubmarineType { Militar, Pesquisa, Turismo }
        #endregion
    }
}