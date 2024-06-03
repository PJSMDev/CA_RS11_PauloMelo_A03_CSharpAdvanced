namespace E01_OOP_Vehicle_PauloMelo_v03.Interfaces
{
    public interface IVehicle
    {
        #region Properties
        int Id { get; }
        int Year { get; set; }
        #endregion

        #region Methods
        void Create();
        void Start();
        void Move();
        void Stop();
        #endregion
    }
}