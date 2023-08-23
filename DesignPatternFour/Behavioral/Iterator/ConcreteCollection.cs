using DesignPatternFour.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Behavioral.Iterator
{
    internal class ConcreteCollection : IAbstractIterator
    {
        private List<Employee> listEmployees = new List<Employee>();

        public int Count { get { return listEmployees.Count; } }

        public bool IsCompleted => throw new NotImplementedException();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }

        public Employee First()
        {
            throw new NotImplementedException();
        }

        public Employee Next()
        {
            throw new NotImplementedException();
        }
    }
}
