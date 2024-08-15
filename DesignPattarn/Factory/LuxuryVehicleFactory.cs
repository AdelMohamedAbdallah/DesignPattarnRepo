namespace DesignPattarn.Factory
{
    public class LuxuryVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new LuxuryCar();
        }

        public ITruck CreateTurck()
        {
            return new LuxuryTruck();
        }
    }
}
