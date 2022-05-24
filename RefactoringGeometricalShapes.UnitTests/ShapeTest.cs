using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace RefactoringGeometricalShapes.UnitTests
{
    /// <summary>
    /// The unit tests for shapes
    /// Unit tests can be updated so they work correctly, however keep in mind to retain the scenarios. The scenarios are there to validate the implementation.
    /// You are of course free to add tests at will.
    /// </summary>
    public class ShapeTest
    {
        [Fact]
        public void testReportForEmptyListOfShapes()
        {
            var result = Shape.prettyPrint(new List<Shape>(), 0);
            result.Should().Be("<h1>Lege lijst van vormen!</h1>");
        }

        [Fact]
        public void testReportForEmptyListOfShapesAndEnglishLanguage()
        {
            var result = Shape.prettyPrint(new List<Shape>(), 1);
            result.Should().Be("<h1>Empty list of shapes!</h1>");
        }

        [Fact]
        public void testReportForOneSquare()
        {
            var shapes = new List<Shape>
            {
                new Shape(Shape.SQUARE, 1)
            };
            var result = Shape.prettyPrint(shapes, 0);
            result.Should().Be("<h1>Samenvatting vormen</h1><br/>1 Vierkant Oppervlakte 1 Omtrek 4<br/>TOTAL:<br/>1 vormen Omtrek 4 Oppervlakte 1");
        }

        [Fact]
        public void testReportForMoreSquares()
        {
            var shapes = new List<Shape>
            {
                new Shape(Shape.SQUARE, 1),
                new Shape(Shape.SQUARE, 2)
            };
            var result = Shape.prettyPrint(shapes, 0);
            result.Should().Be("<h1>Samenvatting vormen</h1><br/>2 Vierkanten Oppervlakte 5 Omtrek 12<br/>TOTAL:<br/>2 vormen Omtrek 12 Oppervlakte 5");
        }

        [Fact]
        public void testReportForMoreShapes()
        {
            var shapes = new List<Shape>
            {
                new Shape(Shape.CIRCLE, 1),
                new Shape(Shape.SQUARE, 1),
                new Shape(Shape.EQUILATERAL_TRIANGLE, 2),
                new Shape(Shape.SQUARE, 2),
                new Shape(Shape.SQUARE, 3),
                new Shape(Shape.CIRCLE, 2)
            };
            var result = Shape.prettyPrint(shapes, 0);
            result.Should().Be("<h1>Samenvatting vormen</h1><br/>3 Vierkanten Oppervlakte 14 Omtrek 24<br/>2 Cirkels Oppervlakte 3,93 Omtrek 9,42<br/>1 Driehoek Oppervlakte 1,73 Omtrek 6<br/>TOTAL:<br/>6 vormen Omtrek 39,42 Oppervlakte 19,66");
        }

        [Fact]
        public void testReportForMoreShapesAndEnglishLanguage()
        {
            var shapes = new List<Shape>
            {
                new Shape(Shape.CIRCLE, 1),
                new Shape(Shape.SQUARE, 1),
                new Shape(Shape.EQUILATERAL_TRIANGLE, 2),
                new Shape(Shape.SQUARE, 2),
                new Shape(Shape.SQUARE, 3),
                new Shape(Shape.CIRCLE, 2)
            };
            var result = Shape.prettyPrint(shapes, 1);
            result.Should().Be("<h1>Shapes report</h1><br/>3 Squares Area 14 Perimeter 24<br/>2 Circles Area 3,93 Perimeter 9,42<br/>1 Triangle Area 1,73 Perimeter 6<br/>TOTAL:<br/>6 shapes Perimeter 39,42 Area 19,66");
        }
    }
}