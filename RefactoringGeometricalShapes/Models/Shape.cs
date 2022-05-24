using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace RefactoringGeometricalShapes.Models
{
    public abstract class Shape
    {
        private readonly double width;

        public double Width { get => width; }

        public Shape(double width)
        {
            this.width = width;
        }

        public abstract double GetArea();
        public abstract double getPerimeter();
    }
}
