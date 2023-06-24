using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildinInterface
{
    internal class TestIEnumerable :IEnumerable<object>
    {
        public static void CollectionSum(IEnumerable<int> collection)
        {
            int sum = 0;

            foreach(var item in collection)
            {
                sum += item;

            }
            Console.WriteLine("Sum is {0}",sum);
        }

        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
