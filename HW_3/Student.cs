using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal struct Student
    {
        public string name;
        public int age;

        public Student(string v1, int v2) : this()
        {
            name = v1;
            age = v2;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
}
