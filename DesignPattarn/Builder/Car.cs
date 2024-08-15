namespace DesignPattarn.Builder
{
    public class Car
    {
        public string? Name { get; set; }
        public Guid Model { get; set; }
        public int Speed { get; set; }
        public DateOnly Creationyear { get; set; }
        public bool Lastversion { get; set; }


        public override string ToString()
        {
            return $"{Name}\t" +
                $"{Model.ToString().Substring(0, 5)}\t" +
                $"{Speed} Km/h\t" +
                $"{Creationyear.ToString("dd/MM/yyyy")}\t" +
                $"{Lastversion}";
        }
    }
}
