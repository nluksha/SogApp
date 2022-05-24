using FluentAssertions;
using System.Collections.Generic;
using System.Resources;
using Xunit;
using RefactoringGeometricalShapes.Models;

namespace RefactoringGeometricalShapes.UnitTests
{
    /// <summary>
    /// The unit tests for shapes
    /// Unit tests can be updated so they work correctly, however keep in mind to retain the scenarios. The scenarios are there to validate the implementation.
    /// You are of course free to add tests at will.
    /// </summary>
    public class ShapeTest
    {
        private ResourceManager rm;

        public ShapeTest()
        {
            rm = new ResourceManager("RefactoringGeometricalShapes.Resources.Strings", typeof(ShapePresenter).Assembly);
        }

        [Fact]
        public void testReportForEmptyListOfShapes()
        {
            var sp = new ShapePresenter(rm);
            
            var result = sp.PrettyPrint(new List<Shape>(), "nl");

            result.Should().Be("<h1>Lege lijst van vormen!</h1>");
        }

        [Fact]
        public void testReportForEmptyListOfShapesAndEnglishLanguage()
        {
            var sp = new ShapePresenter(rm);

            var result = sp.PrettyPrint(new List<Shape>(), "en");

            result.Should().Be("<h1>Empty list of shapes!</h1>");
        }


        [Fact]
        public void testReportForOneSquare()
        {
            var sp = new ShapePresenter(rm);
            var shapes = new List<Shape>
            {
                new Square(1)
            };

            var result = sp.PrettyPrint(shapes, "nl");

            result.Should().Be("<h1>Samenvatting vormen</h1><br/>1 Vierkant Oppervlakte 1 Omtrek 4<br/>TOTAL:<br/>1 vormen Oppervlakte 1 Omtrek 4");
        }

        [Fact]
        public void testReportForMoreSquares()
        {
            var sp = new ShapePresenter(rm);
            var shapes = new List<Shape>
            {
                new Square(1),
                new Square(2)
            };

            var result = sp.PrettyPrint(shapes, "nl");

            result.Should().Be("<h1>Samenvatting vormen</h1><br/>2 Vierkanten Oppervlakte 5 Omtrek 12<br/>TOTAL:<br/>2 vormen Oppervlakte 5 Omtrek 12");
        }

        [Fact]
        public void testReportForMoreShapes()
        {
            var sp = new ShapePresenter(rm);
            var shapes = new List<Shape>
            {
                new Circle(1),
                new Square(1),
                new EquilateralTriangle(2),
                new Square(2),
                new Square(3),
                new Circle(2)
            };

            var result = sp.PrettyPrint(shapes, "nl");

            result.Should().Be("<h1>Samenvatting vormen</h1><br/>3 Vierkanten Oppervlakte 14 Omtrek 24<br/>2 Cirkels Oppervlakte 3.93 Omtrek 9.42<br/>1 Driehoek Oppervlakte 1.73 Omtrek 6<br/>TOTAL:<br/>6 vormen Oppervlakte 19.66 Omtrek 39.42");
        }

        [Fact]
        public void testReportForMoreShapesAndEnglishLanguage()
        {
            var sp = new ShapePresenter(rm);
            var shapes = new List<Shape>
            {
                new Circle(1),
                new Square(1),
                new EquilateralTriangle(2),
                new Square(2),
                new Square(3),
                new Circle(2)
            };

            var result = sp.PrettyPrint(shapes, "en");

            result.Should().Be("<h1>Shapes report</h1><br/>3 Squares Area 14 Perimeter 24<br/>2 Circles Area 3.93 Perimeter 9.42<br/>1 Triangle Area 1.73 Perimeter 6<br/>TOTAL:<br/>6 shapes Area 19.66 Perimeter 39.42");
        }
    }
}