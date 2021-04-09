// https://www.youtube.com/watch?v=EWDmWbJ4wRA

using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Structural Design Patterns: Composite");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            ITodoList todoList = new Project("Test ToDo", new List<ITodoList>()
            {
                new Todo("Do something")
            });

            Console.WriteLine(todoList.GetHtml());
        }
    }
}
