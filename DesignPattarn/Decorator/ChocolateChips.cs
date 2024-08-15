namespace DesignPattarn.Decorator
{
    public class ChocolateChips : IceCreamDecorator
    {
        public ChocolateChips(IceCream iceCream) : base(iceCream)
        {

        }

        public override string Description => $"{base.Description} With Chocolate Chips";

        public override decimal Price() => base.Price() + 0.30m;

    }

}