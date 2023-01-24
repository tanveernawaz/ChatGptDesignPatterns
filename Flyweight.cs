using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    class Flyweight
    {
        private int _intrinsicState;

        public Flyweight(int intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            Console.WriteLine("Flyweight: " + _intrinsicState + ", " + extrinsicState);
        }
    }

    class FlyweightFactory
    {
        private IDictionary<int, Flyweight> _flyweights = new Dictionary<int, Flyweight>();

        public Flyweight GetFlyweight(int intrinsicState)
        {
            if (!_flyweights.ContainsKey(intrinsicState))
            {
                _flyweights[intrinsicState] = new Flyweight(intrinsicState);
            }
            return _flyweights[intrinsicState];
        }
    }

}
