using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("ConcreteHandlerA handled the request: " + request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }

    class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("ConcreteHandlerB handled the request: " + request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }

    class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("ConcreteHandlerC handled the request: " + request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
