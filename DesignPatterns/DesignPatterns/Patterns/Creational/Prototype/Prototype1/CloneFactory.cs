using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototype1
{
    class CloneFactory
    {
        public Animal GetClone(Animal animalSample)
        {
            return (Animal)animalSample.Clone();
        }
    }
}
