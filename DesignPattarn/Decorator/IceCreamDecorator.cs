namespace DesignPattarn.Decorator
{
    public class IceCreamDecorator : IceCream
    {
        private readonly IceCream _iceCream;
        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Description => _iceCream.Description;

        public override decimal Price() => _iceCream.Price();
    }
}
