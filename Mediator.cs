using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }

    public class ConcreteMediator : IMediator
    {
        private Colleague _colleague1;
        private Colleague _colleague2;

        public void Register(Colleague colleague)
        {
            if (colleague is Colleague1)
            {
                _colleague1 = colleague;
            }
            else
            {
                _colleague2 = colleague;
            }
        }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Notify(string message);
    }

    public class Colleague1 : Colleague
    {
        public Colleague1(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }

    public class Colleague2 : Colleague
    {
        public Colleague2(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }

}
