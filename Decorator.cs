using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    interface IDecoComponent
    {
        void Operation();
    }

    class ConcreteComponent : IDecoComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    class Decorator : IDecoComponent
    {
        protected IDecoComponent component;

        public Decorator(IDecoComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IDecoComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IDecoComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
    }

}
