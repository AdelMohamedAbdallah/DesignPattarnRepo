namespace DesignPattarn.CompositeInheretance
{
    public class BlackOlive : ITopping
    {
        public string Title => nameof(BlackOlive);

        public decimal Price => 2m;
    }
}
