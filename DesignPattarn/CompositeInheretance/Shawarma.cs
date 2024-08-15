namespace DesignPattarn.CompositeInheretance
{
    public class Shawarma : ITopping
    {
        public string Title => nameof(Shawarma);

        public decimal Price => 10m;
    }
}
