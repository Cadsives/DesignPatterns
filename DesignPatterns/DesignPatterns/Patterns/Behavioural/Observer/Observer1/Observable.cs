using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Observer.Observer1
{
    interface Observable
    {
        public void RegisterObserver(Student student);
        public void RemoveObserver(Student student);
        public void NotifyObservers();
    }
}
