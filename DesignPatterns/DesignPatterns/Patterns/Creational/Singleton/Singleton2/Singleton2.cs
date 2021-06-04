using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Singleton
{
    sealed class Singleton2
    {
        // Thread Safe
        private static Singleton2 uniqueInstance = null;
        private static readonly object padlock = new object();

        private Singleton2()
        {

        }

        public static Singleton2 Instance
        {
            get
            {
                lock(padlock)
                {
                    if(uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton2();
                    }
                    return uniqueInstance;
                }
            }
        }
    }
}
