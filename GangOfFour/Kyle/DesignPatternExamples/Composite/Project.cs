using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Project : ITodoList
    {
        public string ToDoTitle { get; set; }
        List<ITodoList> todos;

        public Project(string title, List<ITodoList> todos)
        {
            this.ToDoTitle = title;
            this.todos = todos;
        }

        public string GetHtml()
        {
            StringBuilder html = new StringBuilder("<h1>");
            html.AppendLine($"{ToDoTitle}</h1><ul>");

            foreach(ITodoList tl in todos)
            {
                html.AppendLine("<li>");
                html.AppendLine(tl.GetHtml());
                html.AppendLine("</li>");
            }
            html.AppendLine("</ul>");

            return html.ToString();
        }
    }
}
