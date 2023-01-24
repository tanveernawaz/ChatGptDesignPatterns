using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    interface IAggregate
    {
        IIterator CreateIterator();
    }

    interface IIterator
    {
        bool HasNext();
        object Next();
    }

    class ConcreteAggregate : IAggregate
    {
        private List<object> items = new List<object>();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    class ConcreteIterator : IIterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }

        public bool HasNext()
        {
            return current < aggregate.Count - 1;
        }

        public object Next()
        {
            return aggregate[++current];
        }
    }

}
