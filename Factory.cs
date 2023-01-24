using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    // Factory Method

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    interface IProduct
    {
        string Operation();
    }

    class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductA}";
        }
    }

    class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductB}";
        }
    }
}
