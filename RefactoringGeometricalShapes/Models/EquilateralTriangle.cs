using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes.Models
{
    public class EquilateralTriangle : Shape
    {
        public double Side => Width;

        public EquilateralTriangle(double side)
            : base(side)
        {
        }

        public override double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Side * Side;
        }

        public override double getPerimeter()
        {
            return 3 * Side;
        }
    }
}
