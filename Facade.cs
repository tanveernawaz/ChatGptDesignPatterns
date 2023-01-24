using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    class ComplexSystem
    {
        public void MethodA()
        {
            Console.WriteLine("ComplexSystem.MethodA()");
        }

        public void MethodB()
        {
            Console.WriteLine("ComplexSystem.MethodB()");
        }

        public void MethodC()
        {
            Console.WriteLine("ComplexSystem.MethodC()");
        }
    }

    class Façade
    {
        private ComplexSystem _complexSystem;

        public Façade(ComplexSystem complexSystem)
        {
            _complexSystem = complexSystem;
        }

        public void Method1()
        {
            Console.WriteLine("Façade.Method1()");
            _complexSystem.MethodA();
            _complexSystem.MethodB();
        }

        public void Method2()
        {
            Console.WriteLine("Façade.Method2()");
            _complexSystem.MethodB();
            _complexSystem.MethodC();
        }
    }

}
