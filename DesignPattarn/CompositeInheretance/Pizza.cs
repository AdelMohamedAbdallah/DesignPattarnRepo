namespace DesignPattarn.CompositeInheretance
{
    public class Pizza
    {
        public static string Title => nameof(Pizza);

        public static decimal Price => 15m;


        private AccessPizza accesspizza { get; set; } = new();
        public void AddTopicsOnPizza()
        {
            Toppings choise;
            while (true)
            {
                Console.Clear();
                choise = (Toppings)accesspizza.ChoiseToppings();
                ITopping? topping = null;
                switch (choise)
                {
                    case Toppings.CHICKEN:
                        topping = new Chicken();
                        break;
                    case Toppings.CHEESE:
                        topping = new Cheese();
                        break;
                    case Toppings.SHAWARMA:
                        topping = new Shawarma();
                        break;
                    case Toppings.MIXCHEESE:
                        topping = new MixCheese();
                        break;
                    case Toppings.BLACKOLIVE:
                        topping = new BlackOlive();
                        break;
                    case Toppings.TOMATO:
                        topping = new Tomato();
                        break;
                    case Toppings.SAUSAGE:
                        topping = new Sausage();
                        break;
                    default:
                        return;
                };
                accesspizza.AddTopping(topping);
            }
        }

        public override string ToString()
        {
            return $"Product : {accesspizza.TotalTitle()}\nPrice:{accesspizza.CaculatePrice().ToString("C2")}";
        }
    }
}
