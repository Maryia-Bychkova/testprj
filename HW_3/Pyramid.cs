using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Pyramid : Shape
    {
        public double Height;
        public double S;

        public Pyramid(string name, double height, double s) 
            : base(name)
        {
            Height = height;
            S = s;

        }

        public override double Volume()
        {
            return 13 * S * Height;

        }

        public override void GetInformation()
        {
            Console.WriteLine($"объём фигуры Pyramid под названием {_name} равен: {Volume()} ");
        }

    }
}
