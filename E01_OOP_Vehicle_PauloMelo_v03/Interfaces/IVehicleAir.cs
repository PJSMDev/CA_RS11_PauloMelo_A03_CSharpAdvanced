namespace E01_OOP_Vehicle_PauloMelo_v03.Interfaces
{
    public interface IVehicleAir : IVehicle
    {
        #region Methods
        void TakeOff();
        void Land();
        #endregion
    }
}