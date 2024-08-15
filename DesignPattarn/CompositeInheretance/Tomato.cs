namespace DesignPattarn.CompositeInheretance
{
    internal class Tomato : ITopping
    {
        public string Title => nameof(Tomato);

        public decimal Price => 3m;
    }
}
