using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Singleton.Singleton1
{
    // Not Thread Safe
    sealed class Singleton
    {
        private static Singleton uniqueInstance = null;
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new Singleton();
                }
                return uniqueInstance;
            }
        }
    }
}
