namespace DesignPattarn.Decorator
{
    public class Sprinkles : IceCreamDecorator
    {
        public Sprinkles(IceCream iceCream) : base(iceCream)
        {

        }

        public override string Description => $"{base.Description} With Sprinkles";

        public override decimal Price() => base.Price() + 0.25m;

    }

}