using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Singleton
{
    public sealed class SingletonNoThreadSafe
    {
        private static int Counter = 0;

        private static readonly Lazy<SingletonNoThreadSafe> singleTonInstance = new Lazy<SingletonNoThreadSafe>(()=> new SingletonNoThreadSafe() );

        //private static SingletonNoThreadSafe singletonInstance = null;
        //private static readonly object Instancelock = new object();
        //private static SingletonNoThreadSafe singleTonInstance = null;
        public static SingletonNoThreadSafe GetInstance()
        {
           /* lock(Instancelock)
            {
                if (singleTonInstance == null)
                {
                    singleTonInstance = new SingletonNoThreadSafe();

                }

            }*/
            
            return singleTonInstance.Value;
        }

        private SingletonNoThreadSafe()
        {
            Counter++;
            Console.WriteLine("Counter Value :{0}", Counter.ToString());

        }
        public void ShowDetails(string message)
        {
            Console.WriteLine(message);
        }

        

    }
}
