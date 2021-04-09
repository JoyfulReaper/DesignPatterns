using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Todo : ITodoList
    {
        public string ToDoText { get; set; }

        public Todo(string toDoText)
        {
            this.ToDoText = toDoText;
        }

        public string GetHtml()
        {
            return ToDoText;
        }
    }
}
