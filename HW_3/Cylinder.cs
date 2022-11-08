using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Cylinder : Shape
    {
        public double Height;
        public double Radius;

        public Cylinder(string name, double height, double radius)
            : base(name)
        {
            Height = height;
            Radius = radius;

        }

        public override double Volume()
        {
            return Math.PI * (Radius * Radius) * Height;

        }

        public override void GetInformation()
        {
            Console.WriteLine($"объём фигуры Cylinder под названием {_name} равен: {Volume()} ");
        }
    }
}
