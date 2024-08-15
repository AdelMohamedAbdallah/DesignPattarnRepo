namespace DesignPattarn.Decorator
{
    public class FruiteMix : IceCreamDecorator
    {
        public FruiteMix(IceCream iceCream) : base(iceCream)
        {

        }

        public override string Description => $"{base.Description} With Fruite Mix";

        public override decimal Price() => base.Price() + 0.75m;

    }

}