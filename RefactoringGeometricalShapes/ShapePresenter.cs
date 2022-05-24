using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Globalization;
using RefactoringGeometricalShapes.Models;

namespace RefactoringGeometricalShapes
{
    public class ShapePresenter
    {
        private ResourceManager rm;

        public ShapePresenter(ResourceManager rm)
        {
            this.rm = rm;
        }

        public string PrettyPrint(List<Shape> shapes, string userLanguage = "en")
        {
            var cultureInfo = new CultureInfo(userLanguage);
            var formatter = new HtmlFormatter();

            if (shapes.Count() == 0)
            {
                formatter.H1(rm.GetString(Constants.EMPTY_LIST, cultureInfo));
                return formatter.ToString();
            }

            formatter.H1(rm.GetString(Constants.TITLE, cultureInfo)).BR();

            var squares = shapes.Where(x => x is Square).ToList();
            var circles = shapes.Where(x => x is Circle).ToList();
            var triangles = shapes.Where(x => x is EquilateralTriangle).ToList();

            if (squares.Count() != 0)
            {
                formatter.Line(getLine(squares, rm.GetString(Constants.SQUARE, cultureInfo), rm.GetString(Constants.SQUARE_ALT, cultureInfo), cultureInfo)).BR();
            }
            if (circles.Count() != 0)
            {
                formatter.Line(getLine(circles, rm.GetString(Constants.CIRCLE, cultureInfo), rm.GetString(Constants.CIRCLE_ALT, cultureInfo), cultureInfo)).BR();
            }
            if (triangles.Count() != 0)
            {
                formatter.Line(getLine(triangles, rm.GetString(Constants.TRIANGLE, cultureInfo), rm.GetString(Constants.TRIANGLE_ALT, cultureInfo), cultureInfo)).BR();
            }

            formatter.Line("TOTAL:").BR();
            formatter.Line(getLine(shapes, rm.GetString(Constants.SHAPES, cultureInfo), rm.GetString(Constants.SHAPES, cultureInfo), cultureInfo));

            return formatter.ToString();
        }

        private string getLine(List<Shape> shapes, string name, string alternativeName, CultureInfo cultureInfo)
        {
            var count = shapes.Count();
            var area = shapes.Sum(x => x.GetArea());
            var perimeter = shapes.Sum(x => x.getPerimeter());
            var description = count == 1 ? name : alternativeName;
            var areaLabel = rm.GetString(Constants.AREA, cultureInfo);
            var perimeterLabel = rm.GetString(Constants.PERIMETER, cultureInfo);

            return $"{count} {description} {areaLabel} {area.ToString("#.##")} {perimeterLabel} {perimeter.ToString("#.##")}";
        }
    }
}
