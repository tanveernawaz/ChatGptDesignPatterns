using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    // State interface
    interface IState
    {
        void Handle();
    }

    // Concrete State A
    class StateA : IState
    {
        public void Handle()
        {
            Console.WriteLine("Handling in State A");
        }
    }

    // Concrete State B
    class StateB : IState
    {
        public void Handle()
        {
            Console.WriteLine("Handling in State B");
        }
    }

    // Context
    class StateContext
    {
        private IState currentState;

        public StateContext()
        {
            currentState = new StateA();
        }

        public void Request()
        {
            currentState.Handle();
        }

        public IState CurrentState
        {
            set { currentState = value; }
        }
    }

    // Client
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Context context = new Context();
    //        context.Request(); // Output: Handling in State A

    //        context.CurrentState = new StateB();
    //        context.Request(); // Output: Handling in State B
    //    }
    //}

}
