using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    public interface IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount);
    }

    public class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
            return new Tea();
        }
    }

    public class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
            return new Coffee();
        }
    }

    public interface IHotDrink
    {
        void Consume();
    }

    class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }

    class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is delicious!");
        }
    }

    class HotDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffee, Tea
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = Activator.CreateInstance(
                    Type.GetType("AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
                ) as IHotDrinkFactory;
                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
