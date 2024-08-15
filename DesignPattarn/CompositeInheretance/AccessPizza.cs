using System.Collections.ObjectModel;

namespace DesignPattarn.CompositeInheretance
{
    public class AccessPizza
    {
        private static List<ITopping> TopingsAccess = new List<ITopping>();
        public ReadOnlyCollection<ITopping> TopingsReader = new ReadOnlyCollection<ITopping>(TopingsAccess);

        public void AddTopping(ITopping topping) => TopingsAccess.Add(topping);

        public decimal CaculatePrice()
        {
            decimal price = Pizza.Price;
            foreach (var item in TopingsReader)
            {
                price += item.Price;
            }
            return price;
        }

        public string TotalTitle()
        {
            string totaltitle = Pizza.Title;
            foreach (var item in TopingsReader)
            {
                totaltitle += "\n\t\tWith " + item.Title + $" => ({item.Price.ToString("C2")})";
            }
            return totaltitle;
        }

        public int ChoiseToppings()
        {
            Console.WriteLine("Topics : \n\t*(1) => Chicken");
            Console.WriteLine("\t*(2) => Cheese");
            Console.WriteLine("\t*(3) => Shawarma");
            Console.WriteLine("\t*(4) => Mix Cheese");
            Console.WriteLine("\t*(5) => Black Olive");
            Console.WriteLine("\t*(6) => Tomato");
            Console.WriteLine("\t*(7) => Sausage");
            Console.WriteLine("\t*(8) => Exit or Pizza without Toppings\n");
            Console.Write("Enter your Choise : ");
            int.TryParse(Console.ReadLine(), out int choise);
            return choise;
        }

    }
}
