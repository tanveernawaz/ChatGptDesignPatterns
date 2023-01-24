using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    interface ISubject
    {
        void Request();
    }

    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }

    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }

}
