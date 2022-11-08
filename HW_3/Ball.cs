using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOP3
{
    internal class Ball : Shape
    {
        public double Radius;

        public Ball(string name, double radius)
            : base(name)
        {
            Radius = radius;


        }

        public override double Volume()
        {
            return 4/3 * Math.PI *( Radius * Radius * Radius);
           
        }

        public override void GetInformation()
        {
            Console.WriteLine($"объём фигуры Ball под названием {_name} равен: {Volume()} ");
        }

    }

}
