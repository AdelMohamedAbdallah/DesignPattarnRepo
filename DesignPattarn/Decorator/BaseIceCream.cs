namespace DesignPattarn.Decorator
{
    public class BaseIceCream : IceCream
    {
        public override string Description => "Ice Cream";

        public override decimal Price() => 4m;
    }
}
