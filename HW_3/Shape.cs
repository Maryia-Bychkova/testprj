using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public abstract class Shape
    {
        protected string? _name;

        public Shape(string name)
        {
            _name = name;

        }


        public abstract double Volume();

        public virtual void GetInformation()
        {
            Console.WriteLine($"объём Вашей фигуры под названием {_name} равен: {Volume()} ");
        }
       
    }



    
}
