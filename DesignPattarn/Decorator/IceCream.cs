namespace DesignPattarn.Decorator
{
    public abstract class IceCream
    {
        public abstract string Description { get; }
        public abstract decimal Price();

        public override string ToString()
        {
            return $"{Description} => {Price().ToString("C")}";
        }
    }
}
