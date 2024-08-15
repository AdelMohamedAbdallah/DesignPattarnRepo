namespace DesignPattarn.Factory
{
    public class EconomyVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new EconomyCar();
        }

        public ITruck CreateTurck()
        {
            return new EconomyTruck();
        }
    }
}
