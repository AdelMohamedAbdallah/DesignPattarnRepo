namespace DesignPattarn.CompositeInheretance
{
    public class Chicken : ITopping
    {
        public string Title => nameof(Chicken);

        public decimal Price => 10m;
    }
}
