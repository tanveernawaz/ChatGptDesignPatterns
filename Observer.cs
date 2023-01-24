using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    // Subject interface
    public interface IObserverSubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    // Concrete Subject
    public class StockMarket : IObserverSubject
    {
        private List<IObserver> observers;
        private float stockPrice;

        public StockMarket()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stockPrice);
            }
        }

        public void SetStockPrice(float price)
        {
            stockPrice = price;
            NotifyObservers();
        }
    }

    // Observer interface
    public interface IObserver
    {
        void Update(float stockPrice);
    }

    // Concrete Observer
    public class StockTrader : IObserver
    {
        private float stockPrice;

        public void Update(float stockPrice)
        {
            this.stockPrice = stockPrice;
            Console.WriteLine("Stock price updated to: " + stockPrice);
        }
    }

    // Client
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StockMarket stockMarket = new StockMarket();
    //        StockTrader trader1 = new StockTrader();
    //        StockTrader trader2 = new StockTrader();

    //        stockMarket.RegisterObserver(trader1);
    //        stockMarket.RegisterObserver(trader2);

    //        stockMarket.SetStockPrice(100.0f); // this will notify the observer
    //        stockMarket.SetStockPrice(120.0f); // this will notify the observer
    //    }
    //}


}
