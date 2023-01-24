using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    interface ICommand
    {
        void Execute();
    }
    class SimpleCommand : ICommand
    {
        private string _payload;
        public SimpleCommand(string payload)
        {
            _payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine(_payload);
        }
    }
    class Invoker
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
