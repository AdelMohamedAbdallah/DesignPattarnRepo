namespace DesignPattarn.Singleton
{
    public class Area
    {
        private static double area { get; set; }

        private Area()
        {

        }

        private static Area? istance = null;
        private static object locker = new object();

        public static Area GetArea
        {
            get
            {
                if (istance == null)
                {
                    lock (locker)
                    {
                        istance = new Area();
                    }
                }
                return istance;
            }
        }

        public double SquareArea(double length) => area = Math.Pow(length, 2);

        public double CirclArea(double length) => area = Math.PI * Math.Pow(length, 2);





    }
}
