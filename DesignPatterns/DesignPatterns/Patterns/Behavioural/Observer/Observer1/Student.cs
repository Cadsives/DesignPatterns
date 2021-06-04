using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Observer.Observer1
{
    class Student : Observer, DisplayElement
    {
        private string Name { get; set; }
        private string updates { get; set; }

        public Student(string name)
        {
            Name = name;
        }
        
        public void Display()
        {
            string news = "News for " + Name + "\n";

            news = news + updates;

            Console.WriteLine(news);
        }

        public void Update(string theNews)
        {
            updates = theNews;
            Display();
        }
    }
}
