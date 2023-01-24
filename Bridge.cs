using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    internal class Bridge
    {
    }
    // Implementor interface
    interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
    }

    // Concrete Implementor
    class BasicRemote : IRemoteControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Basic remote is turning on the device.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Basic remote is turning off the device.");
        }
    }

    // Concrete Implementor
    class AdvancedRemote : IRemoteControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Advanced remote is turning on the device.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Advanced remote is turning off the device.");
        }
    }

    // Abstraction
    abstract class RemoteControl
    {
        protected IRemoteControl implementor;
        public RemoteControl(IRemoteControl implementor)
        {
            this.implementor = implementor;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    // Refined Abstraction
    class TVRemoteControl : RemoteControl
    {
        public TVRemoteControl(IRemoteControl implementor) : base(implementor) { }
        public override void TurnOn()
        {
            implementor.TurnOn();
        }
        public override void TurnOff()
        {
            implementor.TurnOff();
        }
    }
}
