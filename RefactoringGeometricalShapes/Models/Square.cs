using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes.Models
{
    public class Square : Shape
    {
        public Square(double width)
            :base(width)
        {
        }

        public override double GetArea()
        {
            return Width * Width;
        }

        public override double getPerimeter()
        {
            return Width * 4;
        }
    }
}
