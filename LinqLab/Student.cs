using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Student
    {
        private string v1;
        private int v2;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
