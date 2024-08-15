namespace DesignPattarn.CompositeInheretance
{
    public class MixCheese : ITopping
    {
        public string Title => nameof(MixCheese);

        public decimal Price => 5m;
    }
}
