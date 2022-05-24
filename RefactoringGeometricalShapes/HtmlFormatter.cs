using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class HtmlFormatter
    {
        private StringBuilder html = new StringBuilder();

        private HtmlFormatter addTag(string tagName, string value = "")
        {
            if (string.IsNullOrEmpty(value))
            {
                html.Append($"<{tagName}/>");
            } else
            {
                html.Append($"<{tagName}>{value}</{tagName}>");
            }

            return this;
        }

        public HtmlFormatter H1(string value)
        {
            return addTag("h1", value);
        }

        public HtmlFormatter BR()
        {
            return addTag("br");
        }

        public HtmlFormatter Line(string value)
        {
            html.Append(value);

            return this;
        }

        public override string ToString()
        {
            return html.ToString();
        }
    }
}
