using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes.Models
{
    public class Circle : Shape
    {
        public double Diameter => Width;

        public Circle(double diameter)
            : base(diameter)
        {
        }

        public override double GetArea()
        {
            return Math.PI * (Diameter / 2) * (Diameter / 2);
        }

        public override double getPerimeter()
        {
            return Math.PI * Diameter;
        }
    }
}
