using DesignPatternFour.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Behavioral.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private ConcreteCollection Collection;

        private int Current = 0;
        private readonly int Step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this.Collection = collection;
        }
       

        public Employee First()
        {
            Current = 0;
            return Collection.GetEmployee(Current);
        }

        public Employee Next()
        {
            Current += Step;
            if(!IsCompleted)
            {
                return Collection.GetEmployee(Current);

            }
            return null;
        }

        public bool IsCompleted
        {
            get { return Current >= Collection.Count; }
        }

        
    }
}
