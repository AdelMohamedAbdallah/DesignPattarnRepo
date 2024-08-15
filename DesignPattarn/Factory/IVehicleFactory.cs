namespace DesignPattarn.Factory
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        ITruck CreateTurck();
    }
}
