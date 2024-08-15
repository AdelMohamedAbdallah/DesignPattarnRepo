using DesignPattarn.CompositeInheretance;

namespace DesignPattarn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[Singleton design pattarn]
            //var getarea = Area.GetArea;
            //Console.WriteLine(getarea.SquareArea(10));
            //Console.WriteLine(getarea.CirclArea(10));

            //var getarea1 = Area.GetArea;
            //Console.WriteLine(getarea1.SquareArea(12));
            //Console.WriteLine(getarea1.CirclArea(12));

            //object input = "Hello";
            //string message = input switch
            //{
            //    int _ => "The input is an integer.",
            //    string _ => "The input is a string.",
            //    double _ => "The input is a double.",
            //    _ => $"{default}"
            //};
            //Console.WriteLine(message);
            //[Factory design pattarn]
            //IVehicleFactory luxuryvehicle = new LuxuryVehicleFactory();
            //ICar car = luxuryvehicle.CreateCar();
            //car.Drive();

            //ITruck truck = luxuryvehicle.CreateTurck();
            //truck.Drive();

            //IVehicleFactory EconomyVehicle = new EconomyVehicleFactory();
            //ICar car1 = EconomyVehicle.CreateCar();
            //car1.Drive();

            //ITruck truck1 = EconomyVehicle.CreateTurck();
            //truck1.Drive();

            //[Builder design pattarn]
            //var car = new CarBuilder()
            //    .SetName("BMW")
            //    .SetModel(Guid.NewGuid())
            //    .SetSpeed(180)
            //    .SetCreationYear(new DateOnly(2022, 9, 28))
            //    .SetLastVersion(false)
            //    .Build();

            //Console.WriteLine(car);

            //[Decorator design pattarn]

            //IceCream iceCream = new BaseIceCream();
            //iceCream = new Sprinkles(iceCream);
            //iceCream = new ChocolateChips(iceCream);
            //iceCream = new FruiteMix(iceCream);
            //Console.WriteLine(iceCream);

            Pizza pizza = new Pizza();
            pizza.AddTopicsOnPizza();
            Console.WriteLine(pizza);





        }
    }
}
