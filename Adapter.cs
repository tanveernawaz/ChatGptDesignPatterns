using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    //Adapter Structural Design Pattern

    // Target interface
    interface ITarget
    {
        void Request();
    }

    // Adaptee class
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific Request");
        }
    }

    // Adapter class
    class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
