namespace DesignPattarn.CompositeInheretance
{
    public class Sausage : ITopping
    {
        public string Title => nameof(Sausage);

        public decimal Price => 15m;
    }
}
