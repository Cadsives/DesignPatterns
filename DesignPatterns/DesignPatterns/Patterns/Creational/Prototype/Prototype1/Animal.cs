using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototype1
{
    interface Animal : ICloneable
    {
        public abstract string ToString();
    }
}
