namespace DesignPattarn.CompositeInheretance
{
    public class Cheese : ITopping
    {
        public string Title => nameof(Cheese);

        public decimal Price => 4m;
    }
}
