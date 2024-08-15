namespace DesignPattarn.Builder
{
    internal class CarBuilder
    {
        private readonly Car _car = new();

        public CarBuilder SetName(string name)
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder SetModel(Guid model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetSpeed(int speed)
        {
            _car.Speed = speed;
            return this;
        }

        public CarBuilder SetCreationYear(DateOnly creationyear)
        {
            _car.Creationyear = creationyear;
            return this;
        }

        public CarBuilder SetLastVersion(bool lastversion)
        {
            _car.Lastversion = lastversion;
            return this;
        }

        public Car Build()
        {
            return _car;
        }

    }
}
