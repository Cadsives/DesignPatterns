using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Observer.Observer1
{
    class Lecturer : Observable
    {
        public string News { get; set; }
        private List<Student> myStudents = new List<Student>();

        public Lecturer(string name)
        {
            News = name;
        }
        public void RegisterObserver(Student student)
        {
            myStudents.Add(student);
        }
        public void RemoveObserver(Student student)
        {
            myStudents.Remove(student);
        }
        public void NotifyObservers()
        {
           foreach(Student student in myStudents)
            {
                student.Update(News);
            }
        }
    }
}
