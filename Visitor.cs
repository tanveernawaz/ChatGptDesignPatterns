using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }

    interface IElement
    {
        void Accept(IVisitor visitor);
    }

    class ConcreteVisitor1 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("ConcreteVisitor1 is visiting ElementA.");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("ConcreteVisitor1 is visiting ElementB.");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("ConcreteVisitor2 is visiting ElementA.");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("ConcreteVisitor2 is visiting ElementB.");
        }
    }

    class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class ObjectStructure
    {
        private List<IElement> elements = new List<IElement>();

        public void Attach(IElement element)
        {
            elements.Add(element);
        }

        public void Detach(IElement element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ObjectStructure objectStructure = new ObjectStructure();
    //        objectStructure.Attach(new ElementA());
    //        objectStructure.Attach(new ElementB());

    //        ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
    //        ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

    //        objectStructure.Accept(visitor1);
    //        objectStructure.Accept(visitor2);
    //    }
    //}

}
