using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Thread_Safety_Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? instance = null;
        private static readonly Object obj = new Object();
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
        }

        /*
         * why we should use sealed keyword in the singleton class
         * 
         *       public class SingletonDerived : Singleton
         *       {
         *       }
         */
    }
}
